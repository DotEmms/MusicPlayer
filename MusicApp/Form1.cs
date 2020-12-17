using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            WMPLib.WindowsMediaPlayer Player;

             void PlayFile(String url)
            {
                Player = new WMPLib.WindowsMediaPlayer();
                Player.PlayStateChange +=
                    new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
                Player.MediaError +=
                    new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
                Player.URL = url;
                Player.controls.play();
            }

            void Form1_Load(object sender, System.EventArgs e)
            {
                // TODO  Insert a valid path in the line below.
                PlayFile(@"c:/music/Commercial.mp3");
            }

            void Player_PlayStateChange(int NewState)
            {
                if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    this.Close();
                }
            }

            void Player_MediaError(object pMediaObject)
            {
                MessageBox.Show("Cannot play media file.");
                this.Close();
            }
        }
    }
}
