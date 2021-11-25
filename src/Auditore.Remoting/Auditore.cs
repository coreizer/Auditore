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
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

using Auditore.Library;

namespace Auditore.Remoting
{
    public class Auditore : IDisposable
    {
        #region フィールド

        private readonly AuditoreRefObject auditoreObject;
        private readonly IpcClientChannel clientChannel;

        private bool disposedValue = false;

        #endregion

        #region プロパティ

        public bool IsBouyomiChan
        {
            get {
                return Process.GetProcesses().Any(x => x.ProcessName == "BouyomiChan");
            }
        }

        /// <summary>
        /// ミュート状態かどうかを取得します。
        /// </summary>
        public bool IsMuted
        {
            get {
                return (!this.IsBouyomiChan && this.Volume <= 0);
            }
        }

        /// <summary>
        /// タスクが保留されているかどうかを設定または取得します。
        /// </summary>
        public bool Pause
        {
            get {
                if (!this.IsBouyomiChan) {
                    return false;
                }

                return this.auditoreObject.Pause;
            }

            set {
                if (!this.IsBouyomiChan) {
                    return;
                }

                this.auditoreObject.Pause = value;
            }
        }

        /// <summary>
        /// 音量を設定または取得します。
        /// </summary>
        public int Volume
        {
            get {
                if (!this.IsBouyomiChan) {
                    return 0;
                }

                return this.auditoreObject.Volume;
            }

            set {
                if (!this.IsBouyomiChan) {
                    return;
                }

                this.auditoreObject.Volume = value;
            }
        }

        /// <summary>
        /// 話速を設定または取得します。
        /// </summary>
        public int SpeechSpeed
        {
            get {
                if (!this.IsBouyomiChan) {
                    return 50;
                }

                return this.auditoreObject.SpeechSpeed;
            }
            set {
                if (!this.IsBouyomiChan) {
                    return;
                }

                this.auditoreObject.SpeechSpeed = value;
            }
        }

        /// <summary>
        /// トーンを設定または取得します。
        /// </summary>
        public int Pitch
        {
            get {
                if (!this.IsBouyomiChan) {
                    return 50;
                }

                return this.auditoreObject.Pitch;
            }
            set {
                if (!this.IsBouyomiChan) {
                    return;
                }

                this.auditoreObject.Pitch = value;
            }
        }

        /// <summary>
        /// 現在のタスクID取得します。
        /// </summary>
        public int CurrentTaskId
        {
            get {
                if (!this.IsBouyomiChan) {
                    return -1;
                }

                return this.auditoreObject.CurrentTaskId;
            }
        }

        /// <summary>
        /// 現在のタスク数を取得します。
        /// </summary>
        public int TaskCount
        {
            get {
                if (!this.IsBouyomiChan) {
                    return -1;
                }

                return this.auditoreObject.TaskCount;
            }
        }

        /// <summary>
        /// このライブラリーのバージョンを取得します。
        /// </summary>
        public string Version
        {
            get {
                if (!this.IsBouyomiChan) {
                    return "Error";
                }

                return this.auditoreObject.Version;
            }
        }

        #endregion

        ~Auditore()
        {
            this.Dispose(false);
        }

        public Auditore()
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

            this.auditoreObject = new AuditoreRefObject();
        }

        /// <summary>
        /// タスクにメッセージを追加します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <returns>このタスクのIDが返されます</returns>
        public int Push(string message)
        {
            return this.PushCore(message);
        }

        /// <summary>
        /// タスクにメッセージを追加します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="speechSpeed">話速</param>
        /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <returns>このタスクのIDが返されます</returns>
        public int Push(string message, int speechSpeed)
        {
            return this.PushCore(message, speechSpeed);
        }

        /// <summary>
        /// タスクにメッセージを追加します。
        /// </summary>
        /// <param name="message">メッセージ</param>
        /// <param name="speechSpeed">話速</param>
        /// <param name="volume">音量</param>
        /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <returns>このタスクのIDが返されます</returns>
        public int Push(string message, int speechSpeed, int volume)
        {
            return this.PushCore(message, speechSpeed, volume);
        }

        /// <summary>
        /// タスクにメッセージを追加します
        /// </summary>
        /// <param name="isForce">強制的にメッセージをミュート状態に関わらず、タスクに追加します</param>
        /// <param name="message">メッセージ</param>
        /// <param name="speechSpeed">話速</param>
        /// <param name="volume">音量</param>
        /// <returns>このタスクのIDが返されます</returns>
        public virtual int PushCore(string message, int speechSpeed = -1, int volume = -1)
        {
            if (!this.IsBouyomiChan) {
                return -1;
            }

            return this.auditoreObject.PushMessage(message, speechSpeed, volume);
        }

        /// <summary>
        /// 予約されているタスクをすべて削除します。
        /// </summary>
        public void ClaerAll()
        {
            this.auditoreObject.ClearAll();
        }

        /// <summary>
        /// 全てのタスクをキャンセルします。
        /// </summary>
        public void Reset()
        {
            if (this.IsBouyomiChan) {
                this.auditoreObject.ClearAll();
                this.auditoreObject.Skip();
            }
        }

        /// <summary>
        ///	現在進行中のタスクをスキップします。
        /// </summary>
        public void Skip()
        {
            if (this.IsBouyomiChan) {
                this.auditoreObject.Skip();
            }
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
