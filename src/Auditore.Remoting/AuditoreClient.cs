/*
 * © 2021 coreizer
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

using Auditore.Library;
using Auditore.Remoting.Enums;

using WebSocketSharp;

namespace Auditore.Remoting
{
   public class AuditoreClient : IDisposable
   {
      #region フィールド

      private readonly AuditoreRefObject auditoreRefObject;
      private readonly IpcClientChannel clientChannel;

      private WebSocket webSocket;

      private bool disposedValue = false;

      #endregion

      /// <summary>
      /// ミュート状態かどうかを取得します。
      /// </summary>
      public bool IsMuted {
         get {
            if (this.SpeakerState == AuditoreState.Dying) {
               return true;
            }

            if (this.Volume == 0) {
               return true;
            }

            return false;
         }
      }

      /// <summary>
      /// タスクが保留されているかどうかを設定または取得します。
      /// </summary>
      public bool Pause {
         get {
            return this.auditoreRefObject.Pause;
         }

         set {
            this.auditoreRefObject.Pause = value;
         }
      }

      /// <summary>
      /// 音量を設定または取得します。
      /// </summary>
      public int Volume {
         get {
            return this.auditoreRefObject.Volume;
         }

         set {
            this.auditoreRefObject.Volume = value;
         }
      }

      /// <summary>
      /// 話速を設定または取得します。
      /// </summary>
      public int SpeechSpeed {
         get {
            return this.auditoreRefObject.SpeechSpeed;
         }
         set {
            this.auditoreRefObject.SpeechSpeed = value;
         }
      }

      /// <summary>
      /// トーンを設定または取得します。
      /// </summary>
      public int Pitch {
         get {
            return this.auditoreRefObject.Pitch;
         }
         set {
            this.auditoreRefObject.Pitch = value;
         }
      }

      /// <summary>
      /// 現在のタスクID取得します。
      /// </summary>
      public int CurrentTaskId {
         get {
            return this.auditoreRefObject.CurrentQueueId;
         }
      }

      /// <summary>
      /// 現在のタスク数を取得します。
      /// </summary>
      public int TaskCount {
         get {
            return this.auditoreRefObject.QueueCount;
         }
      }

      public AuditoreState SpeakerState {
         get;
         set;
      } = AuditoreState.Speaking;

      /// <summary>
      /// 依存プロセスが存在するかどうかを確認します。
      /// </summary>
      public bool IsProcessRunning {
         get {
            return Process.GetProcesses().Any(x => x.ProcessName == "BouyomiChan");
         }
      }

      /// <summary>
      /// このライブラリーのバージョンを取得します。
      /// </summary>
      public string Version {
         get {
            return this.auditoreRefObject.Version;
         }
      }

      ~AuditoreClient()
      {
         this.Dispose(false);
      }

      public AuditoreClient()
      {
         // IPC クライアントチャンネルを作成
         this.clientChannel = new IpcClientChannel();

         // チャンネルを登録します
         ChannelServices.RegisterChannel(this.clientChannel, true);

         // リモートオブジェクトの型を登録します
         RemotingConfiguration.RegisterWellKnownClientType(
            typeof(AuditoreRefObject),
            Constants.IPC
         );

         this.auditoreRefObject = new AuditoreRefObject();

         // WebSocket 送信用にチャットに参加します
         this.WebSocketChatJoin();
      }

      private void WebSocketChatJoin()
      {
         this.webSocket = new WebSocket("ws://localhost:1337/chat");
         this.webSocket.ConnectAsync();
      }

      public void SocketPush(string message)
      {
         if (!this.webSocket.IsAlive) {
            throw new Exception("WebSocket接続が失敗しました");
         }

         this.webSocket.Send(message);
      }

      /// <summary>
      /// タスクにメッセージを追加します。
      /// </summary>
      /// <param name="message">メッセージ</param>
      /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int Push(string message, bool isForce = false)
      {
         return this.PushCore(isForce, message);
      }

      /// <summary>
      /// タスクにメッセージを追加します。
      /// </summary>
      /// <param name="message">メッセージ</param>
      /// <param name="speechSpeed">話速</param>
      /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int Push(string message, int speechSpeed, bool isForce = false)
      {
         return this.PushCore(isForce, message, speechSpeed);
      }

      /// <summary>
      /// タスクにメッセージを追加します。
      /// </summary>
      /// <param name="message">メッセージ</param>
      /// <param name="speechSpeed">話速</param>
      /// <param name="volume">音量</param>
      /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int Push(string message, int speechSpeed, int volume, bool isForce = false)
      {
         return this.PushCore(isForce, message, speechSpeed, volume);
      }

      /// <summary>
      /// 予約されているタスクをすべて削除します。
      /// </summary>
      public void ClaerAll()
      {
         this.auditoreRefObject.ClearAll();
      }

      /// <summary>
      /// 全てのタスクをキャンセルします。
      /// </summary>
      public void Reset()
      {
         this.auditoreRefObject.ClearAll();
         this.auditoreRefObject.Skip();
      }

      /// <summary>
      ///	現在進行中のタスクをスキップします。
      /// </summary>
      public void Skip()
      {
         this.auditoreRefObject.Skip();
      }

      /// <summary>
      /// タスクにメッセージを追加します
      /// </summary>
      /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
      /// <param name="message">メッセージ</param>
      /// <param name="speechSpeed">話速</param>
      /// <param name="volume">音量</param>
      /// <returns>このタスクのIDが返されます</returns>
      public virtual int PushCore(bool isForce, string message, int speechSpeed = -1, int volume = -1)
      {
         if (!this.IsProcessRunning) {
            throw new Win32Exception("依存プロセスが存在しません");
         }

         if (isForce || this.SpeakerState == AuditoreState.Speaking) {
            return this.auditoreRefObject.PushMessage(message, speechSpeed, volume);
         }

         return -1;
      }

      protected virtual void Dispose(bool disposing)
      {
         if (!this.disposedValue) {
            try {
               ChannelServices.UnregisterChannel(this.clientChannel);
            }
            catch (Exception ex) {
               Debug.WriteLine(ex.Message);
            }

            this.disposedValue = true;
         }
      }

      public void Dispose()
      {
         this.Dispose(true);
         GC.SuppressFinalize(this);
      }
   }
}
