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

namespace Auditore.Library
{
   public static class Constants
   {
      /// <summary>
      /// プラグインバージョンが定義されています。
      /// </summary>
      public const string VersionString = "1.5";

      /// <summary>
      /// チャンネル名が定義されています。
      /// </summary>
      public const string ChannelName = "message";

      /// <summary>
      /// チャンネルオブジェクトUriが定義されています。
      /// </summary>
      public const string PortName = "auditore";

      /// <summary>
      /// チャンネルIPCが定義されています。
      /// </summary>
      public const string IPC = "ipc://auditore/message";

      /// <summary>
      /// プラグイン設定パスが定義されています。
      /// </summary>
      public const string Settings = "auditore.setting";
   }
}
