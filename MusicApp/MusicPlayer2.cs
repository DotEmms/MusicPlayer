using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MusicApp
{
    class MusicPlayer2
    {
        //static void MusicPlayer()
        //{

        //}

        //public static void PlayMusic(string file)
        //{
        //    WindowsMediaPlayer player = new WindowsMediaPlayer();
        //    _WMPOCXEvents_PlayStateChangeEventHandler player_PlayStateChange = null;
        //    player.PlayStateChange += player_PlayStateChange;
        //    player.controls.stop();
        //    player.URL = file;
        //    player.controls.play();
        //}
        //public static void PlayCommercial(string file)
        //{
        //    WindowsMediaPlayer player = new WindowsMediaPlayer();
        //    _WMPOCXEvents_PlayStateChangeEventHandler player_PlayStateChange = null;
        //    player.PlayStateChange += player_PlayStateChange;
        //    player.URL = file;
        //    player.controls.play();
        //}


        public static void PlayMusic(string path)
        {
            WindowsMediaPlayer Player = new WindowsMediaPlayer();
            Player.URL = path;
            Player.controls.play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO  Insert a valid path in the line below.
            PlayMusic(@"c:\myaudio.wma");
        }

        public static void Volume()
        {
            Console.WriteLine("Geef aan met 'up' of 'down' of u uw volume wil verhogen of verlagen");//volume regelen
            string volume = Console.ReadLine();
            while (volume != null)
            {
                switch (volume)//switch om volume te verhogen of verlagen
                {
                    case "up":
                        {
                            VolumeUp();
                            break;
                        }
                    case "down":
                        {
                            VolumeDown();
                            break;
                        }
                    default:
                        Error();
                        break;
                }
            }
        }

        public static void VolumeUp()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            if (player.settings.volume < 90)
            {
                player.settings.volume = player.settings.volume + 10;
            }
        }

        public static void VolumeDown()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            if (player.settings.volume > 1)
            {
                player.settings.volume = player.settings.volume - (player.settings.volume / 2);
            }
        }

        public static void Error()
        {
            Console.WriteLine("Geen geldige invoer!");
        }

        public static void PauseMusic(string file)
        {
            throw new NotImplementedException();
        }

        public static void StopMusic(string file)
        {
            throw new NotImplementedException();
        }
    }
}
