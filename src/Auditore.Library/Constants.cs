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

using FNF.Utility;

namespace Auditore.Library
{
   public static class Constants
   {
      /// <summary>
      /// チャンネル名を取得します。
      /// 
      /// message
      /// </summary>
      public static readonly string ChannelName = "message";

      /// <summary>
      /// チャンネルオブジェクトUriを取得します。
      /// 
      /// auditore
      /// </summary>
      public static readonly string PortName = "auditore";

      /// <summary>
      /// チャンネルIPCを取得します。
      /// 
      /// ipc://auditore/message
      /// </summary>
      public static readonly string IPC = "ipc://auditore/message";

      /// <summary>
      /// プラグイン設定パスを取得します。
      /// </summary>
      public static readonly string Settings = Base.CallAsmPath + "auditore.setting";
   }
}
