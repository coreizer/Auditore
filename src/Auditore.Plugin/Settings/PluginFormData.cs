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

using FNF.XmlSerializerSetting;

namespace Auditore.Plugin.Settings
{

   public class PluginFormData : ISettingFormData
   {
      #region フィールド

      private readonly PluginSettings settings;

      #endregion

      #region プロパティ

      /// <summary>
      /// プラグインのタイトルを設定します
      /// </summary>
      public string Title => "Auditore プラグイン";

      public bool ExpandAll => false;

      /// <summary>
      /// プラグインの設定を取得します
      /// </summary>
      public SettingsBase Setting => this.settings;

      #endregion

      public PluginFormData(PluginSettings settings) => this.settings = settings;
   }
}
