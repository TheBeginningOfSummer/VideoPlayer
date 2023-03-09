using CCWin;
using System;
using System.Windows.Forms;

namespace WindowsPlayer
{
    public partial class PlayerForm : CCSkinMain
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

            LB_VideoTime.Text = "00:00:00/00:00:00";

            is_playinig_ = false;
        }

        private void BTN_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vlc_player_.PlayFile(ofd.FileName);
                TB_PlayerTrack.SetRange(0, (int)vlc_player_.Duration());
                TB_PlayerTrack.Value = 0;
                timer1.Start();
                is_playinig_ = true;
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                vlc_player_.Stop();
                TB_PlayerTrack.Value = 0;
                timer1.Stop();
                is_playinig_ = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                if (TB_PlayerTrack.Value == TB_PlayerTrack.Maximum)
                {
                    vlc_player_.Stop();
                    timer1.Stop();
                }
                else
                {
                    TB_PlayerTrack.Value = TB_PlayerTrack.Value + 1;
                    LB_VideoTime.Text = string.Format("{0}/{1}",
                        GetTimeString(TB_PlayerTrack.Value),
                        GetTimeString(TB_PlayerTrack.Maximum));
                }
            }
        }

        private string GetTimeString(int val)
        {
            int hour = val / 3600;
            val %= 3600;
            int minute = val / 60;
            int second = val % 60;
            return string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }

        private void TB_PlayerTrack_Scroll(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                vlc_player_.SetPlayTime(TB_PlayerTrack.Value);
                TB_PlayerTrack.Value = (int)vlc_player_.GetPlayTime();
            }
        }

        private void PN_Display_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
