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

using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using Auditore.Library;

namespace Auditore.Remoting {
  public class AuditoreClient : IAuditoreClient, IDisposable {
    #region フィールド

    private readonly AuditoreRefObject auditoreObject;
    private readonly IpcClientChannel clientChannel;

    private bool disposedValue = false;

    private int _last_Volume;

    #endregion

    #region プロパティ

    /// <summary>
    /// 棒読みちゃんのプロセスが起動およびプラグインが読み込まれているかどうかを確認します。
    /// </summary>
    public bool IsBouyomiChan => this.IsProcessRunning();

    /// <summary>
    /// ミュート状態かどうかを取得します。
    /// </summary>
    public bool IsMuted => (this.IsBouyomiChan && this.Volume <= 0);

    /// <summary>
    /// タスクが保留されているかどうかを設定または取得します。
    /// </summary>
    public bool Pause {
      get => !this.IsBouyomiChan && this.auditoreObject.Pause;
      set {
        if (!this.IsBouyomiChan)
          return;
        this.auditoreObject.Pause = value;
      }
    }

    /// <summary>
    /// 音量を設定または取得します。
    /// </summary>
    public int Volume {
      get => this.IsBouyomiChan ? this.auditoreObject.Volume : 0;
      set {
        if (!this.IsBouyomiChan)
          return;
        this.auditoreObject.Volume = value;
      }
    }

    /// <summary>
    /// 話速を設定または取得します。
    /// </summary>
    public int TalkSpeed {
      get => this.IsBouyomiChan ? this.auditoreObject.TalkSpeed : 50;
      set {
        if (!this.IsBouyomiChan)
          return;
        this.auditoreObject.TalkSpeed = value;
      }
    }

    /// <summary>
    /// トーンを設定または取得します。
    /// </summary>
    public int Pitch {
      get => this.IsBouyomiChan ? this.auditoreObject.Pitch : 50;
      set {
        if (!this.IsBouyomiChan)
          return;
        this.auditoreObject.Pitch = value;
      }
    }

    /// <summary>
    /// 現在のタスクID取得します。
    /// </summary>
    public int CurrentTaskId {
      get => this.IsBouyomiChan ? this.auditoreObject.CurrentTaskId : -1;
    }

    /// <summary>
    /// 現在のタスク数を取得します。
    /// </summary>
    public int TaskCount {
      get => this.IsBouyomiChan ? this.auditoreObject.TaskCount : -1;
    }

    /// <summary>
    /// このライブラリーのバージョンを取得します。
    /// </summary>
    public string Version {
      get => this.IsBouyomiChan ? this.auditoreObject.Version : "Error";
    }

    #endregion

    ~AuditoreClient() {
      this.Dispose(false);
    }

    public AuditoreClient() {
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
    /// タスクにテキストメッセージを追加します。
    /// </summary>
    /// <param name="text">テキストメッセージ</param>
    /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
    /// <returns>このタスクのIDが返されます。</returns>
    public virtual int Push(string text) => this.PushCore(text);

    /// <summary>
    /// タスクにテキストメッセージを追加します。
    /// </summary>
    /// <param name="text">テキストメッセージ</param>
    /// <param name="talkSpeed">話速</param>
    /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
    /// <returns>このタスクのIDが返されます。</returns>
    public virtual int Push(string text, int talkSpeed) => this.PushCore(text, talkSpeed);

    /// <summary>
    /// タスクにテキストメッセージを追加します。
    /// </summary>
    /// <param name="text">テキストメッセージ</param>
    /// <param name="talkSpeed">話速</param>
    /// <param name="volume">音量</param>
    /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
    /// <returns>このタスクのIDが返されます。</returns>
    public virtual int Push(string text, int talkSpeed, int volume) => this.PushCore(text, talkSpeed, volume);

    /// <summary>
    /// タスクにテキストメッセージを追加します
    /// </summary>
    /// <param name="isForce">強制的にテキストメッセージをミュート状態に関わらず、タスクに追加します</param>
    /// <param name="text">テキストメッセージ</param>
    /// <param name="talkSpeed">話速</param>
    /// <param name="volume">音量</param>
    /// <returns>このタスクのIDが返されます。</returns>
    public virtual int PushCore(string text, int talkSpeed = -1, int volume = -1)
        => this.IsBouyomiChan ?
            this.auditoreObject.PushText(text, talkSpeed, volume) : -1;

    /// <summary>
    /// 予約されているタスクをすべて削除します。
    /// </summary>
    public virtual void ClaerAll() {
      if (this.IsBouyomiChan) {
        this.auditoreObject.ClearAll();
      }
    }

    /// <summary>
    /// 全てのタスクをキャンセルします。
    /// </summary>
    public virtual void Reset() {
      if (this.IsBouyomiChan) {
        this.auditoreObject.ClearAll();
        this.auditoreObject.Skip();
      }
    }

    /// <summary>
    ///	現在進行中のタスクをスキップします。
    /// </summary>
    public virtual void Skip() {
      if (this.IsBouyomiChan) {
        this.auditoreObject.Skip();
      }
    }

    public virtual void ToggleMute() {
      if (this.IsMuted) {
        this.Volume = this._last_Volume <= 0 ? 50 : this._last_Volume;
      }
      else {
        this._last_Volume = this.Volume;
        this.Volume = 0;
      }
    }

    protected virtual void Dispose(bool disposing) {
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

    public void Dispose() {
      this.Dispose(true);
      GC.SuppressFinalize(this);
    }

    private bool IsProcessRunning(string moduleName = "Plugin_Auditore.dll") {
      try {
        var process = Process.GetProcesses().FirstOrDefault(x => x.ProcessName == "BouyomiChan");
        if (process == null) {
          return false;
        }

        return process.Modules.OfType<ProcessModule>().Any(x => x.FileName.Contains(moduleName));
      }
      catch {
        return false;
      }
    }
  }
}
