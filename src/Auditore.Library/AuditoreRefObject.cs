#region License Info

/*
 * © 2019-2022 coreizer
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

#endregion

using System;
using System.Diagnostics;
using FNF.BouyomiChanApp;
using FNF.Utility;

namespace Auditore.Library
{
   public sealed class AuditoreRefObject : MarshalByRefObject
   {
      #region フィールド

      private const int DEFAULT_SPEED = 100;
      private const int MAX_SPEED = 200;
      private const int MIN_SPEED = 50;

      private const int DEFAULT_VOLUME = 50;
      private const int MAX_VOLUME = 100;
      private const int MIN_VOLUME = 0;

      private const int DEFAULT_PITCH = 100;
      private const int MAX_PITCH = 200;
      private const int MIN_PITCH = 50;

      #endregion フィールド

      #region プロパティ

      /// <summary>
      /// 現在実行されているかどうかを取得します。
      /// </summary>
      public bool NowPlaying => Pub.NowPlaying;

      /// <summary>
      /// 現在実行されているタスクのテキストテキストメッセージを取得します。
      /// </summary>
      public string Source => Pub.FormMain.textBoxSource.Text;

      /// <summary>
      /// タスクが保留されているかどうかを設定または取得します。
      /// </summary>
      public bool Pause
      {
         get => Pub.Pause;

         set => Pub.Pause = value;
      }

      /// <summary>
      /// 現在のタスクID取得します。
      /// </summary>
      public int CurrentTaskId => Pub.NowTaskId;

      /// <summary>
      /// 現在のタスク数を取得します。
      /// </summary>
      public int TaskCount => Pub.TalkTaskCount;

      /// <summary>
      /// 話速を設定または取得します。
      /// </summary>
      public int TalkSpeed
      {
         get => Pub.FormMain.trackBarSpeed.Value;

         set {
            if (MIN_SPEED <= value && value <= MAX_SPEED) {
               Pub.FormMain.trackBarSpeed.Value = value;
            }
            else {
               Pub.FormMain.trackBarSpeed.Value = DEFAULT_SPEED;
            }
         }
      }

      /// <summary>
      /// 音量を設定または取得します。
      /// </summary>
      public int Volume
      {
         get => Pub.FormMain.trackBarVolume.Value;

         set {
            if (MIN_VOLUME <= value && value <= MAX_VOLUME) {
               Pub.FormMain.trackBarVolume.Value = value;
               return;
            }
            else {
               Pub.FormMain.trackBarVolume.Value = DEFAULT_VOLUME;
            }
         }
      }

      /// <summary>
      /// トーンを設定または取得します。
      /// </summary>
      public int Pitch
      {
         get => Pub.FormMain.trackBarTone.Value;

         set {
            if (MIN_PITCH <= value && value <= MAX_PITCH) {
               Pub.FormMain.trackBarTone.Value = value;
               return;
            }
            else {

               Pub.FormMain.trackBarTone.Value = DEFAULT_PITCH;
            }
         }
      }

      /// <summary>
      /// このライブラリのバージョンを取得します。
      /// </summary>
      public string Version => Constants.VersionString;

      #endregion プロパティ

      /// <summary>
      /// タスクにテキストテキストメッセージを追加します。
      /// </summary>
      /// <param name="text">テキストテキストテキストメッセージ</param>
      /// <returns>このタスクのIDが返されます。</returns>
      public int PushText(string text)
      {
         return CorePushText(text, TalkSpeed, Volume, VoiceType.Default);
      }

      /// <summary>
      /// タスクにテキストテキストメッセージを追加します。
      /// </summary>
      /// <param name="text">テキストテキストメッセージ</param>
      /// <param name="talkSpeed">話速設定</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int PushText(string text, int talkSpeed)
      {
         return CorePushText(text, talkSpeed, Volume, VoiceType.Default);
      }

      /// <summary>
      /// タスクにテキストテキストメッセージを追加します。
      /// </summary>
      /// <param name="text">テキストテキストメッセージ</param>
      /// <param name="talkSpeed">話速設定</param>
      /// <param name="volume">音量</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int PushText(string text, int talkSpeed, int volume)
      {
         return CorePushText(text, talkSpeed, volume, VoiceType.Default);
      }

      /// <summary>
      /// タスクにテキストテキストメッセージを追加します。
      /// </summary>
      /// <param name="text">テキストテキストメッセージ</param>
      /// <param name="talkSpeed">話速設定</param>
      /// <param name="volume">音量</param>
      /// <param name="voiceType">ボイスタイプ</param>
      /// <returns>このタスクのIDが返されます</returns>
      public int PushText(string text, int talkSpeed, int volume, VoiceType voiceType)
      {
         return CorePushText(text, talkSpeed, volume, voiceType);
      }

      private int CorePushText(string text, int talkSpeed, int volume, VoiceType voiceType)
      {
         try {
            return Pub.AddTalkTask(text, talkSpeed, volume, voiceType);
         }
         catch (Exception ex) {
            Trace.WriteLine(ex.Message);
            return -1;
         }
      }

      /// <summary>
      /// 予約されているタスクをすべて削除します。
      /// </summary>
      public void ClearAll()
      {
         try {
            Pub.ClearTalkTasks();
         }
         catch (Exception ex) {
            Trace.WriteLine(ex.Message);
         }
      }

      /// <summary>
      ///	現在進行中のタスクをスキップします。
      /// </summary>
      public void Skip()
      {
         try {
            Pub.SkipTalkTask();
         }
         catch (Exception ex) {
            Trace.WriteLine(ex.Message);
         }
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
