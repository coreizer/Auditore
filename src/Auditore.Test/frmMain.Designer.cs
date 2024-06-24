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
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.label7 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.labelVolume = new System.Windows.Forms.Label();
         this.linkLabel1 = new System.Windows.Forms.LinkLabel();
         this.trackBarTest = new System.Windows.Forms.TrackBar();
         this.trackBar1 = new System.Windows.Forms.TrackBar();
         this.labelSpeed = new System.Windows.Forms.Label();
         this.labelTaskId = new System.Windows.Forms.Label();
         this.labelTaskCount = new System.Windows.Forms.Label();
         this.tabPage3 = new System.Windows.Forms.TabPage();
         this.button2 = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.labelUpdatedAt = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.trackBarTest)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
         this.tabPage3.SuspendLayout();
         this.statusStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // textBoxMessage
         // 
         this.textBoxMessage.Location = new System.Drawing.Point(6, 162);
         this.textBoxMessage.Multiline = true;
         this.textBoxMessage.Name = "textBoxMessage";
         this.textBoxMessage.Size = new System.Drawing.Size(275, 120);
         this.textBoxMessage.TabIndex = 0;
         this.textBoxMessage.Text = "こんにちは";
         // 
         // buttonSend
         // 
         this.buttonSend.Location = new System.Drawing.Point(174, 288);
         this.buttonSend.Name = "buttonSend";
         this.buttonSend.Size = new System.Drawing.Size(107, 24);
         this.buttonSend.TabIndex = 1;
         this.buttonSend.Text = "送信";
         this.buttonSend.UseVisualStyleBackColor = true;
         this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage3);
         this.tabControl1.Location = new System.Drawing.Point(12, 12);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(296, 344);
         this.tabControl1.TabIndex = 8;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.label7);
         this.tabPage1.Controls.Add(this.groupBox1);
         this.tabPage1.Controls.Add(this.buttonSend);
         this.tabPage1.Controls.Add(this.textBoxMessage);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(288, 318);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "プレイグラウンド";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(7, 294);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(53, 12);
         this.label7.TabIndex = 7;
         this.label7.Text = "タスク Id : ";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.labelVolume);
         this.groupBox1.Controls.Add(this.linkLabel1);
         this.groupBox1.Controls.Add(this.trackBarTest);
         this.groupBox1.Controls.Add(this.trackBar1);
         this.groupBox1.Controls.Add(this.labelSpeed);
         this.groupBox1.Controls.Add(this.labelTaskId);
         this.groupBox1.Controls.Add(this.labelTaskCount);
         this.groupBox1.Location = new System.Drawing.Point(7, 6);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(274, 150);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "情報";
         // 
         // labelVolume
         // 
         this.labelVolume.AutoSize = true;
         this.labelVolume.Location = new System.Drawing.Point(6, 24);
         this.labelVolume.Name = "labelVolume";
         this.labelVolume.Size = new System.Drawing.Size(39, 12);
         this.labelVolume.TabIndex = 2;
         this.labelVolume.Text = "音量 : ";
         // 
         // linkLabel1
         // 
         this.linkLabel1.AutoSize = true;
         this.linkLabel1.Location = new System.Drawing.Point(235, 124);
         this.linkLabel1.Name = "linkLabel1";
         this.linkLabel1.Size = new System.Drawing.Size(29, 12);
         this.linkLabel1.TabIndex = 0;
         this.linkLabel1.TabStop = true;
         this.linkLabel1.Text = "更新";
         this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
         // 
         // trackBarTest
         // 
         this.trackBarTest.AutoSize = false;
         this.trackBarTest.BackColor = System.Drawing.Color.White;
         this.trackBarTest.Location = new System.Drawing.Point(61, 18);
         this.trackBarTest.Maximum = 100;
         this.trackBarTest.Name = "trackBarTest";
         this.trackBarTest.Size = new System.Drawing.Size(194, 23);
         this.trackBarTest.TabIndex = 0;
         this.trackBarTest.TickStyle = System.Windows.Forms.TickStyle.None;
         this.trackBarTest.Scroll += new System.EventHandler(this.trackBarTest_Scroll);
         this.trackBarTest.Validating += new System.ComponentModel.CancelEventHandler(this.trackBarTest_Validating);
         // 
         // trackBar1
         // 
         this.trackBar1.AutoSize = false;
         this.trackBar1.BackColor = System.Drawing.Color.White;
         this.trackBar1.Location = new System.Drawing.Point(61, 47);
         this.trackBar1.Maximum = 200;
         this.trackBar1.Minimum = 50;
         this.trackBar1.Name = "trackBar1";
         this.trackBar1.Size = new System.Drawing.Size(194, 26);
         this.trackBar1.TabIndex = 3;
         this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
         this.trackBar1.Value = 50;
         this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
         this.trackBar1.Validating += new System.ComponentModel.CancelEventHandler(this.trackBar1_Validating);
         // 
         // labelSpeed
         // 
         this.labelSpeed.AutoSize = true;
         this.labelSpeed.Location = new System.Drawing.Point(6, 52);
         this.labelSpeed.Name = "labelSpeed";
         this.labelSpeed.Size = new System.Drawing.Size(39, 12);
         this.labelSpeed.TabIndex = 4;
         this.labelSpeed.Text = "速度 : ";
         // 
         // labelTaskId
         // 
         this.labelTaskId.AutoSize = true;
         this.labelTaskId.Location = new System.Drawing.Point(6, 100);
         this.labelTaskId.Name = "labelTaskId";
         this.labelTaskId.Size = new System.Drawing.Size(59, 12);
         this.labelTaskId.TabIndex = 5;
         this.labelTaskId.Text = "タスク Id : ...";
         // 
         // labelTaskCount
         // 
         this.labelTaskCount.AutoSize = true;
         this.labelTaskCount.Location = new System.Drawing.Point(6, 124);
         this.labelTaskCount.Name = "labelTaskCount";
         this.labelTaskCount.Size = new System.Drawing.Size(58, 12);
         this.labelTaskCount.TabIndex = 6;
         this.labelTaskCount.Text = "タスク数 : ...";
         // 
         // tabPage3
         // 
         this.tabPage3.Controls.Add(this.button2);
         this.tabPage3.Location = new System.Drawing.Point(4, 22);
         this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
         this.tabPage3.Name = "tabPage3";
         this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
         this.tabPage3.Size = new System.Drawing.Size(289, 322);
         this.tabPage3.TabIndex = 2;
         this.tabPage3.Text = "Test";
         this.tabPage3.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(22, 144);
         this.button2.Margin = new System.Windows.Forms.Padding(2);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(243, 27);
         this.button2.TabIndex = 1;
         this.button2.Text = "棒読みちゃんが起動しているかどうかを確認する";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // statusStrip1
         // 
         this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
         this.statusStrip1.Location = new System.Drawing.Point(0, 365);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
         this.statusStrip1.Size = new System.Drawing.Size(320, 22);
         this.statusStrip1.SizingGrip = false;
         this.statusStrip1.TabIndex = 10;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
         this.toolStripStatusLabel1.Text = "© 2019-2024 coreizer";
         // 
         // labelUpdatedAt
         // 
         this.labelUpdatedAt.AutoSize = true;
         this.labelUpdatedAt.Location = new System.Drawing.Point(187, 539);
         this.labelUpdatedAt.Name = "labelUpdatedAt";
         this.labelUpdatedAt.Size = new System.Drawing.Size(11, 12);
         this.labelUpdatedAt.TabIndex = 7;
         this.labelUpdatedAt.Text = "...";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.tabControl1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Margin = new System.Windows.Forms.Padding(0);
         this.panel1.Name = "panel1";
         this.panel1.Padding = new System.Windows.Forms.Padding(20);
         this.panel1.Size = new System.Drawing.Size(320, 365);
         this.panel1.TabIndex = 11;
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(320, 387);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.labelUpdatedAt);
         this.Controls.Add(this.statusStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Auditore Demo";
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.trackBarTest)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
         this.tabPage3.ResumeLayout(false);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBoxMessage;
      private System.Windows.Forms.Button buttonSend;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label labelUpdatedAt;
      private System.Windows.Forms.Label labelVolume;
      private System.Windows.Forms.TrackBar trackBarTest;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.Label labelSpeed;
      private System.Windows.Forms.Label labelTaskId;
      private System.Windows.Forms.LinkLabel linkLabel1;
      private System.Windows.Forms.Label labelTaskCount;
      private System.Windows.Forms.Panel panel1;
   }
}

