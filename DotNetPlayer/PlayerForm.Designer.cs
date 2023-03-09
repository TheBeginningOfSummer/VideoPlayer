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
            PN_VideoDisplay = new Panel();
            SuspendLayout();
            // 
            // PN_VideoDisplay
            // 
            PN_VideoDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PN_VideoDisplay.BackColor = Color.Black;
            PN_VideoDisplay.Location = new Point(0, 0);
            PN_VideoDisplay.Name = "PN_VideoDisplay";
            PN_VideoDisplay.Size = new Size(801, 404);
            PN_VideoDisplay.TabIndex = 0;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PN_VideoDisplay);
            Name = "PlayerForm";
            Text = "DotNetPlayer";
            ResumeLayout(false);
        }

        #endregion

        private Panel PN_VideoDisplay;
    }
}