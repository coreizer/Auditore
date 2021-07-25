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

namespace Auditore.Test
{
   partial class frmMain
   {
      /// <summary>
      /// 必要なデザイナー変数です。
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 使用中のリソースをすべてクリーンアップします。
      /// </summary>
      /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows フォーム デザイナーで生成されたコード

      /// <summary>
      /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
      /// コード エディターで変更しないでください。
      /// </summary>
      private void InitializeComponent()
      {
         this.textBoxMessage = new System.Windows.Forms.TextBox();
         this.buttonSend = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.trackBar1 = new System.Windows.Forms.TrackBar();
         this.label1 = new System.Windows.Forms.Label();
         this.trackBarTest = new System.Windows.Forms.TrackBar();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.label7 = new System.Windows.Forms.Label();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.label5 = new System.Windows.Forms.Label();
         this.linkLabel1 = new System.Windows.Forms.LinkLabel();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.label6 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBarTest)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.tabPage3.SuspendLayout();
         this.SuspendLayout();
         // 
         // textBoxMessage
         // 
         this.textBoxMessage.Location = new System.Drawing.Point(28, 29);
         this.textBoxMessage.Multiline = true;
         this.textBoxMessage.Name = "textBoxMessage";
         this.textBoxMessage.Size = new System.Drawing.Size(330, 202);
         this.textBoxMessage.TabIndex = 0;
         this.textBoxMessage.Text = "こんにちは";
         // 
         // buttonSend
         // 
         this.buttonSend.Location = new System.Drawing.Point(251, 237);
         this.buttonSend.Name = "buttonSend";
         this.buttonSend.Size = new System.Drawing.Size(107, 24);
         this.buttonSend.TabIndex = 1;
         this.buttonSend.Text = "送信";
         this.buttonSend.UseVisualStyleBackColor = true;
         this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(47, 176);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(52, 12);
         this.label4.TabIndex = 6;
         this.label4.Text = "タスク数 : ";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(47, 146);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(53, 12);
         this.label3.TabIndex = 5;
         this.label3.Text = "タスク Id : ";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(47, 117);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 12);
         this.label2.TabIndex = 4;
         this.label2.Text = "速度 : ";
         // 
         // trackBar1
         // 
         this.trackBar1.AutoSize = false;
         this.trackBar1.BackColor = System.Drawing.Color.White;
         this.trackBar1.Location = new System.Drawing.Point(106, 113);
         this.trackBar1.Maximum = 200;
         this.trackBar1.Minimum = 50;
         this.trackBar1.Name = "trackBar1";
         this.trackBar1.Size = new System.Drawing.Size(205, 26);
         this.trackBar1.TabIndex = 3;
         this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
         this.trackBar1.Value = 50;
         this.trackBar1.Validating += new System.ComponentModel.CancelEventHandler(this.trackBar1_Validating);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(47, 84);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(39, 12);
         this.label1.TabIndex = 2;
         this.label1.Text = "音量 : ";
         // 
         // trackBarTest
         // 
         this.trackBarTest.AutoSize = false;
         this.trackBarTest.BackColor = System.Drawing.Color.White;
         this.trackBarTest.Location = new System.Drawing.Point(106, 84);
         this.trackBarTest.Maximum = 100;
         this.trackBarTest.Name = "trackBarTest";
         this.trackBarTest.Size = new System.Drawing.Size(205, 23);
         this.trackBarTest.TabIndex = 0;
         this.trackBarTest.TickStyle = System.Windows.Forms.TickStyle.None;
         this.trackBarTest.Validating += new System.ComponentModel.CancelEventHandler(this.trackBarTest_Validating);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.Location = new System.Drawing.Point(8, 9);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(389, 316);
         this.tabControl1.TabIndex = 8;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.label7);
         this.tabPage1.Controls.Add(this.textBoxMessage);
         this.tabPage1.Controls.Add(this.buttonSend);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(381, 290);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "プレイグラウンド";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(26, 232);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(53, 12);
         this.label7.TabIndex = 7;
         this.label7.Text = "タスク Id : ";
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.label5);
         this.tabPage2.Controls.Add(this.linkLabel1);
         this.tabPage2.Controls.Add(this.trackBar1);
         this.tabPage2.Controls.Add(this.trackBarTest);
         this.tabPage2.Controls.Add(this.label4);
         this.tabPage2.Controls.Add(this.label1);
         this.tabPage2.Controls.Add(this.label2);
         this.tabPage2.Controls.Add(this.label3);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(381, 290);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "情報";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(13, 248);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(11, 12);
         this.label5.TabIndex = 7;
         this.label5.Text = "...";
         // 
         // linkLabel1
         // 
         this.linkLabel1.AutoSize = true;
         this.linkLabel1.Location = new System.Drawing.Point(321, 12);
         this.linkLabel1.Name = "linkLabel1";
         this.linkLabel1.Size = new System.Drawing.Size(29, 12);
         this.linkLabel1.TabIndex = 0;
         this.linkLabel1.TabStop = true;
         this.linkLabel1.Text = "更新";
         this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
         // 
         // statusStrip1
         // 
         this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 327);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
         this.statusStrip1.Size = new System.Drawing.Size(406, 22);
         this.statusStrip1.TabIndex = 10;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabel1.Text = "© 2019-2021 coreizer";
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.label6);
         this.tabPage3.Controls.Add(this.textBox1);
         this.tabPage3.Controls.Add(this.button1);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage3.Size = new System.Drawing.Size(381, 290);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "tabPage3";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(24, 232);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(53, 12);
         this.label6.TabIndex = 10;
         this.label6.Text = "タスク Id : ";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(26, 29);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(330, 202);
         this.textBox1.TabIndex = 8;
         this.textBox1.Text = "こんにちは";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(249, 237);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(107, 24);
         this.button1.TabIndex = 9;
         this.button1.Text = "送信";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(406, 349);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.tabControl1);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Auditore Demo";
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBarTest)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         this.tabPage2.PerformLayout();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.tabPage3.ResumeLayout(false);
         this.tabPage3.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBoxMessage;
      private System.Windows.Forms.Button buttonSend;
      private System.Windows.Forms.TrackBar trackBarTest;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.LinkLabel linkLabel1;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Button button1;
   }
}

