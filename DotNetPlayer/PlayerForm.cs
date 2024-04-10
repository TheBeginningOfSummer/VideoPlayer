using LibVLCSharp.Shared;

namespace DotNetPlayer
{
    public partial class PlayerForm : Form
    {
        private readonly LibVLC libVLC;
        private readonly MediaPlayer mediaPlayer;
        const string VIDEO_URL = "rtsp://184.72.239.149/vod/mp4:BigBuckBunny_175k.mov";

        public PlayerForm()
        {
            InitializeComponent();
            Core.Initialize();
            libVLC = new LibVLC();
            mediaPlayer = new MediaPlayer(libVLC) { Hwnd = PN_VideoDisplay.Handle };

            //Media video = new Media(libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"));
            Media video = new(libVLC, new Uri("rtsp://127.0.0.1:8554/test"));
            mediaPlayer.Play(video);
            video.Dispose();

        }

        private void TSB_Set_Click(object sender, EventArgs e)
        {

        }
    }
}