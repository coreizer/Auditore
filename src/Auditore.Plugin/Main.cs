﻿/*
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
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Security.Principal;

using Auditore.Library;
using Auditore.Library.WebSockets;
using Auditore.Plugin.Settings;

using FNF.BouyomiChanApp;
using FNF.XmlSerializerSetting;

using WebSocketSharp;
using WebSocketSharp.Server;

namespace Auditore.Plugin
{
   public class Main : IPlugin
   {
      #region フィールド

      private IpcServerChannel serverChannel;

      private PluginSettings settings;
      private PluginFormData settingFormData;

      private WebSocketServer webSocket;

      #endregion フィールド

      #region プロパティ

      /// <summary>
      /// プラグイン名を取得します。
      /// </summary>
      public string Name {
         get {
            return "auditore";
         }
      }

      /// <summary>
      /// プラグインバージョンを取得します。
      /// </summary>
      public string Version {
         get {
            return "1.0.13a";
         }
      }

      /// <summary>
      /// プラグイン説明を取得します。
      /// </summary>
      public string Caption {
         get {
            return "auditore remoting";
         }
      }

      /// <summary>
      /// このプラグインのフォームデータを取得します。
      /// </summary>
      public ISettingFormData SettingFormData {
         get {
            return this.settingFormData;
         }
      }

      #endregion プロパティ

      /// <summary>
      /// プラグインの初期処理を実行します。
      /// </summary>
      public void Begin()
      {
         try {
            IDictionary config = new Hashtable
            {
               ["name"] = "",
               ["portName"] = Constants.PortName,
               ["tokenImpersonationLevel"] = TokenImpersonationLevel.Impersonation,
               ["impersonation"] = true,
               ["secure"] = true
            };

            // IPC チャンネルを作成
            this.serverChannel = new IpcServerChannel(config, null);

            // リモートオブジェクトを登録
            ChannelServices.RegisterChannel(this.serverChannel, true);

            RemotingConfiguration.RegisterWellKnownServiceType(
               typeof(AuditoreRefObject),
               Constants.ChannelName,
               WellKnownObjectMode.Singleton
            );
         }
         catch (Exception ex) {
            System.Windows.Forms.MessageBox.Show($"チャンネルの登録に失敗しました: { ex.Message }", "プラグイン エラー", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
         }

         // プラグイン設定を初期化します
         this.settings = new PluginSettings(this);
         this.settings.Load(Constants.Settings);

         // フォームデータを初期化します
         this.settingFormData = new PluginFormData(this.settings);

         // WebSocket サーバーを作成します
         this.WebSocketServer();
      }

      /// <summary>
      /// プラグインの終了処理を実行します。
      /// </summary>
      public void End()
      {
         ChannelServices.UnregisterChannel(this.serverChannel);
      }

      /// <summary>
      /// ウェブソケットを作成し、接続状態にします
      /// </summary>
      private void WebSocketServer()
      {
         this.webSocket = new WebSocketServer(1337);
         this.webSocket.AddWebSocketService<Chat>("/chat");
         this.webSocket.Start();
      }
   }
}
