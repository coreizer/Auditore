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

using FNF.BouyomiChanApp;
using FNF.Utility;

namespace Auditore.Library
{
   public sealed class AuditoreRefObject : MarshalByRefObject
   {
      #region フィールド

      private const string VersionString = "1.2";

      private const int DefaultSpeed = 100;
      private const int MaxSpeed = 200;
      private const int MinSpeed = 50;

      private const int DefaultVolume = 50;
      private const int MaxVolume = 100;
      private const int MinVolume = 0;

      private const int DefaultPitch = 100;
      private const int MaxPitch = 200;
      private const int MinPitch = 50;

      #endregion フィールド

      #region プロパティ

      /// <summary>
      /// 現在実行されているかどうかを取得します。
      /// </summary>
      public bool NowPlaying {
         get {
            return Pub.NowPlaying;
         }
      }

      /// <summary>
      /// 現在実行されているタスクのメッセージを取得します。
      /// </summary>
      public string Source {
         get {
            return Pub.FormMain.textBoxSource.Text;
         }
      }

      /// <summary>
      /// タスクが保留されているかどうかを設定または取得します。
      /// </summary>
      public bool Pause {
         get {
            return Pub.Pause;
         }

         set {
            Pub.Pause = value;
         }
      }

      /// <summary>
      /// 現在のタスクID取得します。
      /// </summary>
      public int CurrentQueueId {
         get {
            return Pub.NowTaskId;
         }
      }

      /// <summary>
      /// 現在のタスク数を取得します。
      /// </summary>
      public int QueueCount {
         get {
            return Pub.TalkTaskCount;
         }
      }

      /// <summary>
      /// 話速を設定または取得します。
      /// </summary>
      public int SpeechSpeed {
         get {
            return Pub.FormMain.trackBarSpeed.Value;
         }

         set {
            if (MinSpeed <= value && value <= MaxSpeed) {
               Pub.FormMain.trackBarSpeed.Value = value;
            }
            else {
               Pub.FormMain.trackBarSpeed.Value = DefaultSpeed;
            }
         }
      }

      /// <summary>
      /// 音量を設定または取得します。
      /// </summary>
      public int Volume {
         get {
            return Pub.FormMain.trackBarVolume.Value;
         }

         set {
            if (MinVolume <= value && value <= MaxVolume) {
               Pub.FormMain.trackBarVolume.Value = value;
               return;
            }
            else {
               Pub.FormMain.trackBarVolume.Value = DefaultVolume;
            }
         }
      }

      /// <summary>
      /// トーンを設定または取得します。
      /// </summary>
      public int Pitch {
         get {
            return Pub.FormMain.trackBarTone.Value;
         }

         set {
            if (MinPitch <= value && value <= MaxPitch) {
               Pub.FormMain.trackBarTone.Value = value;
               return;
            }
            else {
               Pub.FormMain.trackBarTone.Value = DefaultPitch;
            }
         }
      }

      /// <summary>
      /// このライブラリーのバージョンを取得します。
      /// </summary>
      public string Version {
         get {
            return VersionString;
         }
      }

      #endregion プロパティ

      /// <summary>
      /// タスクにメッセージを追加します。
      /// </summary>
      /// <param name="message">メッセージ</param>
      /// <returns>このタスクのIDが返されます。</returns>
      public int PushMessage(string message)
      {
         return this.CorePushMessage(message, this.SpeechSpeed, this.Volume, VoiceType.Default);
      }

      /// <summary>
      /// タスクにメッセージを追加します。
      /// </summary>
      /// <param name="message">メッセージ</param>
      /// <param name="speechSpeed">話速設定</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int PushMessage(string message, int speechSpeed)
      {
         return this.CorePushMessage(message, speechSpeed, this.Volume, VoiceType.Default);
      }

      /// <summary>
      /// タスクにメッセージを追加します。
      /// </summary>
      /// <param name="message">メッセージ</param>
      /// <param name="speechSpeed">話速設定</param>
      /// <param name="volume">音量</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int PushMessage(string message, int speechSpeed, int volume)
      {
         return this.CorePushMessage(message, speechSpeed, volume, VoiceType.Default);
      }

      /// <summary>
      /// タスクにメッセージを追加します。
      /// </summary>
      /// <param name="message">メッセージ</param>
      /// <param name="speechSpeed">話速設定</param>
      /// <param name="volume">音量</param>
      /// <param name="voice">ボイスタイプ</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int PushMessage(string message, int speechSpeed, int volume, VoiceType voice)
      {
         return this.CorePushMessage(message, speechSpeed, volume, voice);
      }

      private int CorePushMessage(string message, int speechSpeed, int volume, VoiceType voice)
      {
         return Pub.AddTalkTask(message, speechSpeed, volume, (VoiceType)voice);
      }

      /// <summary>
      /// 予約されているタスクをすべて削除します。
      /// </summary>
      public void ClearAll()
      {
         Pub.ClearTalkTasks();
      }

      /// <summary>
      ///	現在進行中のタスクをスキップします。
      /// </summary>
      public void Skip()
      {
         Pub.SkipTalkTask();
      }

      /// <summary>
      /// 有効期間ポリシーを制御する有効期間サービスオブジェクトの期間を無期限に設定するために、オーバーライドしています。
      /// </summary>
      /// <returns>null</returns>
      [System.Security.SecurityCritical]
      public override object InitializeLifetimeService()
      {
         return null;
      }
   }
}
