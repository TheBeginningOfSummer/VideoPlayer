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

        private string GetTimeString(int val)
        {
            int hour = val / 3600;
            val %= 3600;
            int minute = val / 60;
            int second = val % 60;
            return string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                if (LTB_PlayerTrack.L_Value == LTB_PlayerTrack.L_Maximum)
                {
                    vlc_player_.Stop();
                    timer1.Stop();
                    LTB_PlayerTrack.L_Value = 0;
                    is_playinig_ = false;
                }
                else
                {
                    LTB_PlayerTrack.L_Value++;
                    LB_VideoTime.Text = $"{GetTimeString(LTB_PlayerTrack.L_Value)}/{GetTimeString(LTB_PlayerTrack.L_Maximum)}";
                }
            }
        }

        private void LTB_PlayerTrack_MouseDown(object sender, MouseEventArgs e)
        {
            if (is_playinig_)
            {
                vlc_player_.SetPlayTime(LTB_PlayerTrack.L_Value);
                LTB_PlayerTrack.L_Value = (int)vlc_player_.GetPlayTime();
            }
        }

        private void PN_Display_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TSB_Open_Click(object sender, EventArgs e)
        {
            if (OFD_VideoPath.ShowDialog() == DialogResult.OK)
            {
                vlc_player_.PlayFile(OFD_VideoPath.FileName);
                //TB_PlayerTrack.SetRange(0, (int)vlc_player_.Duration());
                LTB_PlayerTrack.L_Minimum = 0;
                LTB_PlayerTrack.L_Maximum = (int)vlc_player_.Duration();
                LTB_PlayerTrack.L_Value = 0;
                timer1.Start();
                is_playinig_ = true;
            }
        }

        private void BTN_Play_Click(object sender, EventArgs e)
        {
            if (is_playinig_) return;
            if (OFD_VideoPath.FileName == "") return;
            vlc_player_.Play();
            timer1.Start();
            is_playinig_ = true;
        }

        private void BTN_Pause_Click(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                vlc_player_.Pause();
                timer1.Stop();
                is_playinig_ = false;
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            if (is_playinig_)
            {
                vlc_player_.Stop();
                timer1.Stop();
                LTB_PlayerTrack.L_Value = 0;
                is_playinig_ = false;
            }
        }

    }
}
