#region License Info

/*
 * © 2019-2024 coreizer
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

namespace Auditore.Remoting
{
    public interface IAuditoreClient
    {
        /// <summary>
        /// ミュート状態かどうかを取得します。
        /// </summary>
        bool IsMuted { get; }

        /// <summary>
        /// タスクが保留されているかどうかを設定または取得します。
        /// </summary>
        bool Pause { get; set; }

        /// <summary>
        /// 音量を設定または取得します。
        /// </summary>
        int Volume { get; set; }

        /// <summary>
        /// 話速を設定または取得します。
        /// </summary>
        int TalkSpeed { get; set; }

        /// <summary>
        /// トーンを設定または取得します。
        /// </summary>
        int Pitch { get; set; }

        /// <summary>
        /// 現在のタスクID取得します。
        /// </summary>
        int CurrentTaskId { get; }

        /// <summary>
        /// 現在のタスク数を取得します。
        /// </summary>
        int TaskCount { get; }

        /// <summary>
        /// このライブラリーのバージョンを取得します。
        /// </summary>
        string Version { get; }

        /// <summary>
        /// タスクにテキストメッセージを追加します。
        /// </summary>
        /// <param name="text">テキストメッセージ</param>
        /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <returns>このタスクのIDが返されます</returns>
        int Push(string text);

        /// <summary>
        /// タスクにテキストメッセージを追加します。
        /// </summary>
        /// <param name="text">テキストメッセージ</param>
        /// <param name="talkSpeed">話速</param>
        /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <returns>このタスクのIDが返されます</returns>
        int Push(string text, int talkSpeed);

        /// <summary>
        /// タスクにテキストメッセージを追加します。
        /// </summary>
        /// <param name="text">テキストメッセージ</param>
        /// <param name="talkSpeed">話速</param>
        /// <param name="volume">音量</param>
        /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <returns>このタスクのIDが返されます</returns>
        int Push(string text, int talkSpeed, int volume);

        /// <summary>
        /// タスクにテキストメッセージを追加します
        /// </summary>
        /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <param name="text">テキストメッセージ</param>
        /// <param name="talkSpeed">話速</param>
        /// <param name="volume">音量</param>
        /// <returns>このタスクのIDが返されます</returns>
        void ClaerAll();

        /// <summary>
        /// 予約されているタスクをすべて削除します。
        /// </summary>
        void Reset();

        /// <summary>
        /// 全てのタスクをキャンセルします。
        /// </summary>
        void Skip();

        void ToggleMute();
    }
}
