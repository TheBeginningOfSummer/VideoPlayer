﻿namespace WindowsPlayer
{
    partial class PlayerForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PN_Display = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTN_Open = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.TB_PlayerTrack = new System.Windows.Forms.TrackBar();
            this.LB_VideoTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TB_PlayerTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Display
            // 
            this.PN_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Display.BackColor = System.Drawing.Color.Black;
            this.PN_Display.Location = new System.Drawing.Point(0, 28);
            this.PN_Display.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Display.Name = "PN_Display";
            this.PN_Display.Size = new System.Drawing.Size(654, 337);
            this.PN_Display.TabIndex = 0;
            this.PN_Display.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Display_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BTN_Open
            // 
            this.BTN_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Open.Location = new System.Drawing.Point(9, 418);
            this.BTN_Open.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Open.Name = "BTN_Open";
            this.BTN_Open.Size = new System.Drawing.Size(75, 23);
            this.BTN_Open.TabIndex = 2;
            this.BTN_Open.Text = "打开";
            this.BTN_Open.UseVisualStyleBackColor = true;
            this.BTN_Open.Click += new System.EventHandler(this.BTN_Open_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Stop.Location = new System.Drawing.Point(87, 418);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(75, 23);
            this.BTN_Stop.TabIndex = 3;
            this.BTN_Stop.Text = "停止";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // TB_PlayerTrack
            // 
            this.TB_PlayerTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_PlayerTrack.Cursor = System.Windows.Forms.Cursors.Default;
            this.TB_PlayerTrack.Location = new System.Drawing.Point(120, 367);
            this.TB_PlayerTrack.Name = "TB_PlayerTrack";
            this.TB_PlayerTrack.Size = new System.Drawing.Size(528, 45);
            this.TB_PlayerTrack.TabIndex = 4;
            this.TB_PlayerTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TB_PlayerTrack.Scroll += new System.EventHandler(this.TB_PlayerTrack_Scroll);
            // 
            // LB_VideoTime
            // 
            this.LB_VideoTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_VideoTime.AutoSize = true;
            this.LB_VideoTime.Location = new System.Drawing.Point(7, 383);
            this.LB_VideoTime.Name = "LB_VideoTime";
            this.LB_VideoTime.Size = new System.Drawing.Size(107, 12);
            this.LB_VideoTime.TabIndex = 5;
            this.LB_VideoTime.Text = "00:00:00/00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.LB_VideoTime);
            this.Controls.Add(this.TB_PlayerTrack);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.BTN_Open);
            this.Controls.Add(this.PN_Display);
            this.Name = "PlayerForm";
            this.Text = "WindowsPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.TB_PlayerTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PN_Display;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BTN_Open;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.TrackBar TB_PlayerTrack;
        private System.Windows.Forms.Label LB_VideoTime;
        private System.Windows.Forms.Timer timer1;
    }
}

