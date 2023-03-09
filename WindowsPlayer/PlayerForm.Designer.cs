namespace WindowsPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.PN_Display = new System.Windows.Forms.Panel();
            this.OFD_VideoPath = new System.Windows.Forms.OpenFileDialog();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.LB_VideoTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LTB_PlayerTrack = new DemoControls.LTrackBar();
            this.STP_Tool = new CCWin.SkinControl.SkinToolStrip();
            this.TSB_Open = new System.Windows.Forms.ToolStripButton();
            this.BTN_Play = new System.Windows.Forms.Button();
            this.BTN_Pause = new System.Windows.Forms.Button();
            this.STP_Tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Display
            // 
            this.PN_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN_Display.BackColor = System.Drawing.Color.Black;
            this.PN_Display.Location = new System.Drawing.Point(0, 50);
            this.PN_Display.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Display.Name = "PN_Display";
            this.PN_Display.Size = new System.Drawing.Size(654, 350);
            this.PN_Display.TabIndex = 0;
            this.PN_Display.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Display_Paint);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Stop.Location = new System.Drawing.Point(139, 420);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(60, 23);
            this.BTN_Stop.TabIndex = 3;
            this.BTN_Stop.Text = "停止";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // LB_VideoTime
            // 
            this.LB_VideoTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_VideoTime.AutoSize = true;
            this.LB_VideoTime.Location = new System.Drawing.Point(7, 403);
            this.LB_VideoTime.Name = "LB_VideoTime";
            this.LB_VideoTime.Size = new System.Drawing.Size(107, 12);
            this.LB_VideoTime.TabIndex = 5;
            this.LB_VideoTime.Text = "00:00:00/00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LTB_PlayerTrack
            // 
            this.LTB_PlayerTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTB_PlayerTrack.L_BarColor = System.Drawing.Color.Gainsboro;
            this.LTB_PlayerTrack.L_BarSize = 10;
            this.LTB_PlayerTrack.L_IsRound = true;
            this.LTB_PlayerTrack.L_Maximum = 100;
            this.LTB_PlayerTrack.L_Minimum = 0;
            this.LTB_PlayerTrack.L_Orientation = DemoControls.Orientation.Horizontal_LR;
            this.LTB_PlayerTrack.L_SliderColor = System.Drawing.Color.LightSkyBlue;
            this.LTB_PlayerTrack.L_Value = 0;
            this.LTB_PlayerTrack.Location = new System.Drawing.Point(119, 403);
            this.LTB_PlayerTrack.Name = "LTB_PlayerTrack";
            this.LTB_PlayerTrack.Size = new System.Drawing.Size(529, 10);
            this.LTB_PlayerTrack.TabIndex = 6;
            this.LTB_PlayerTrack.Text = "lTrackBar1";
            this.LTB_PlayerTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LTB_PlayerTrack_MouseDown);
            // 
            // STP_Tool
            // 
            this.STP_Tool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STP_Tool.Arrow = System.Drawing.Color.Black;
            this.STP_Tool.AutoSize = false;
            this.STP_Tool.Back = System.Drawing.Color.White;
            this.STP_Tool.BackColor = System.Drawing.Color.Transparent;
            this.STP_Tool.BackRadius = 1;
            this.STP_Tool.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.STP_Tool.Base = System.Drawing.Color.White;
            this.STP_Tool.BaseFore = System.Drawing.Color.Black;
            this.STP_Tool.BaseForeAnamorphosis = false;
            this.STP_Tool.BaseForeAnamorphosisBorder = 4;
            this.STP_Tool.BaseForeAnamorphosisColor = System.Drawing.Color.Silver;
            this.STP_Tool.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.STP_Tool.BaseHoverFore = System.Drawing.Color.Silver;
            this.STP_Tool.BaseItemAnamorphosis = true;
            this.STP_Tool.BaseItemBorder = System.Drawing.Color.Silver;
            this.STP_Tool.BaseItemBorderShow = false;
            this.STP_Tool.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("STP_Tool.BaseItemDown")));
            this.STP_Tool.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.STP_Tool.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("STP_Tool.BaseItemMouse")));
            this.STP_Tool.BaseItemNorml = null;
            this.STP_Tool.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.STP_Tool.BaseItemRadius = 1;
            this.STP_Tool.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.STP_Tool.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.STP_Tool.BindTabControl = null;
            this.STP_Tool.Dock = System.Windows.Forms.DockStyle.None;
            this.STP_Tool.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.STP_Tool.Fore = System.Drawing.Color.Black;
            this.STP_Tool.GripMargin = new System.Windows.Forms.Padding(0);
            this.STP_Tool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.STP_Tool.HoverFore = System.Drawing.Color.White;
            this.STP_Tool.ItemAnamorphosis = true;
            this.STP_Tool.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.STP_Tool.ItemBorderShow = true;
            this.STP_Tool.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.STP_Tool.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.STP_Tool.ItemRadius = 1;
            this.STP_Tool.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.STP_Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Open});
            this.STP_Tool.Location = new System.Drawing.Point(1, 25);
            this.STP_Tool.Name = "STP_Tool";
            this.STP_Tool.Padding = new System.Windows.Forms.Padding(0);
            this.STP_Tool.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.STP_Tool.Size = new System.Drawing.Size(653, 25);
            this.STP_Tool.SkinAllColor = true;
            this.STP_Tool.TabIndex = 7;
            this.STP_Tool.Text = "skinToolStrip1";
            this.STP_Tool.TitleAnamorphosis = true;
            this.STP_Tool.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.STP_Tool.TitleRadius = 4;
            this.STP_Tool.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // TSB_Open
            // 
            this.TSB_Open.BackColor = System.Drawing.Color.Black;
            this.TSB_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TSB_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Open.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Open.Image")));
            this.TSB_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Open.Name = "TSB_Open";
            this.TSB_Open.Size = new System.Drawing.Size(36, 22);
            this.TSB_Open.Text = "打开";
            this.TSB_Open.Click += new System.EventHandler(this.TSB_Open_Click);
            // 
            // BTN_Play
            // 
            this.BTN_Play.Location = new System.Drawing.Point(7, 420);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(60, 23);
            this.BTN_Play.TabIndex = 8;
            this.BTN_Play.Text = "播放";
            this.BTN_Play.UseVisualStyleBackColor = true;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // BTN_Pause
            // 
            this.BTN_Pause.Location = new System.Drawing.Point(73, 420);
            this.BTN_Pause.Name = "BTN_Pause";
            this.BTN_Pause.Size = new System.Drawing.Size(60, 23);
            this.BTN_Pause.TabIndex = 9;
            this.BTN_Pause.Text = "暂停";
            this.BTN_Pause.UseVisualStyleBackColor = true;
            this.BTN_Pause.Click += new System.EventHandler(this.BTN_Pause_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.BTN_Pause);
            this.Controls.Add(this.BTN_Play);
            this.Controls.Add(this.STP_Tool);
            this.Controls.Add(this.LTB_PlayerTrack);
            this.Controls.Add(this.LB_VideoTime);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.PN_Display);
            this.Name = "PlayerForm";
            this.Text = "WindowsPlayer";
            this.STP_Tool.ResumeLayout(false);
            this.STP_Tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PN_Display;
        private System.Windows.Forms.OpenFileDialog OFD_VideoPath;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Label LB_VideoTime;
        private System.Windows.Forms.Timer timer1;
        private DemoControls.LTrackBar LTB_PlayerTrack;
        private CCWin.SkinControl.SkinToolStrip STP_Tool;
        private System.Windows.Forms.ToolStripButton TSB_Open;
        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.Button BTN_Pause;
    }
}

