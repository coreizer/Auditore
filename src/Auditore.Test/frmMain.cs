/*
 * © 2019-2021 coreizer
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
using System.Windows.Forms;

namespace Auditore.Test
{
    public partial class frmMain : Form
    {
        private readonly Remoting.AuditoreClient client = new Remoting.AuditoreClient();

        public frmMain()
        {
            this.InitializeComponent();
            this.Playground();
        }

        private void Playground()
        {
            try {
                this.trackBarTest.Value = this.client.Volume;
                this.label1.Text = $"音量 : { this.client.Volume }";

                this.trackBar1.Value = this.client.TalkSpeed;
                this.label2.Text = $"速度 : { this.client.TalkSpeed }";

                this.label3.Text = $"タスク Id : { this.client.CurrentTaskId }";
                this.label4.Text = $"タスク数 : { this.client.TaskCount }";

                this.label5.Text = DateTime.Now.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "取得に失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.label5.Text = "取得に失敗しました";
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try {
                int taskId = this.client.Push(this.textBoxMessage.Text);
                this.label7.Text = $"タスク Id : { taskId }";
                Debug.WriteLine($"追加されたタスクId: { taskId }");

                this.Playground();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "送信に失敗しました", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trackBarTest_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try {
                this.client.Volume = (sender as TrackBar).Value;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void trackBar1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try {
                this.client.TalkSpeed = (sender as TrackBar).Value;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Playground();
        }

        private void trackBarTest_Scroll(object sender, EventArgs e)
        {
            this.client.Volume = (sender as TrackBar).Value;
            this.label1.Text = $"音量 : { this.client.Volume }";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.client.TalkSpeed = (sender as TrackBar).Value;
            this.label2.Text = $"速度 : { this.client.TalkSpeed }";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"IsBouyomiChan: { this.client.IsBouyomiChan }");
        }
    }
}
