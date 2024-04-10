namespace DotNetPlayer
{
    partial class PlayerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            PN_VideoDisplay = new Panel();
            toolStrip1 = new ToolStrip();
            TSB_Set = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PN_VideoDisplay
            // 
            PN_VideoDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PN_VideoDisplay.BackColor = Color.Black;
            PN_VideoDisplay.Location = new Point(0, 28);
            PN_VideoDisplay.Name = "PN_VideoDisplay";
            PN_VideoDisplay.Size = new Size(801, 376);
            PN_VideoDisplay.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSB_Set });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Set
            // 
            TSB_Set.Alignment = ToolStripItemAlignment.Right;
            TSB_Set.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSB_Set.Image = (Image)resources.GetObject("TSB_Set.Image");
            TSB_Set.ImageTransparentColor = Color.Magenta;
            TSB_Set.Name = "TSB_Set";
            TSB_Set.Size = new Size(36, 22);
            TSB_Set.Text = "设置";
            TSB_Set.Click += TSB_Set_Click;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(PN_VideoDisplay);
            Name = "PlayerForm";
            Text = "DotNetPlayer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PN_VideoDisplay;
        private ToolStrip toolStrip1;
        private ToolStripButton TSB_Set;
    }
}