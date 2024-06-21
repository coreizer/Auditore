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

namespace Auditore.Plugin.Settings
{
   using FNF.XmlSerializerSetting;

   public class PluginSettings : SettingsBase
   {
      protected readonly Main plugin;

      public virtual PropertieModel Properties { get; set; } = new PropertieModel();

      public class PropertieModel { }

      public PluginSettings() { }

      public PluginSettings(Main plugin) => this.plugin = plugin;

      public override void ReadSettings() => base.ReadSettings();

      public override void WriteSettings() => base.WriteSettings();
   }
}
