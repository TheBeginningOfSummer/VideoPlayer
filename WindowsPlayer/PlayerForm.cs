using System;
using System.Windows.Forms;

namespace WindowsPlayer
{
    public partial class PlayerForm : Form
    {
        private readonly VlcPlayer vlc_player_;
        private bool is_playinig_;

        public PlayerForm()
        {
            InitializeComponent();

            string pluginPath = Environment.CurrentDirectory + "\\plugins\\";
            vlc_player_ = new VlcPlayer(pluginPath);
            IntPtr render_wnd = this.PN_Display.Handle;
            vlc_player_.SetRenderWindow((int)render_wnd);

            //tbVideoTime.Text = "00:00:00/00:00:00";

            is_playinig_ = false;
        }

        private void BTN_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vlc_player_.PlayFile(ofd.FileName);
                //trackBar1.SetRange(0, (int)vlc_player_.Duration());
                //trackBar1.Value = 0;
                //timer1.Start();
                is_playinig_ = true;
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                vlc_player_.Stop();
                //trackBar1.Value = 0;
                //timer1.Stop();
                is_playinig_ = false;
            }
        }
    }
}
