using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace MusicPlayer
{
    class Music
    {
        WindowsMediaPlayer player;
        public Music()
        {
            player = new WindowsMediaPlayer();
            player.settings.volume = 20;
        } 
        void MusicPlayer()
        {
            
        }
        //void CreatePlaylist()
        //{
        //    WMPLib.IWMPPlaylist playlist = wmp.playlistCollection.newPlaylist("myplaylist");
        //}
        public string GetMusicFile()
        {
            Console.Write("Geef de titel van het liedje in: ");
            string input = Console.ReadLine(); //lees user input (titel)
            string path = "C:/Music/" + input + ".mp3";//aangegeven pad voor het bestand
            Console.WriteLine($"Now playing {input}");
            return path;
        }
        public void PlayMusic(string file)
        {
            //player.URL = file;
            player.PlayStateChange +=
                new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
            player.URL = file;
            player.controls.play();
        }
        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Close();
            }
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        private void Player_MediaError(object pMediaObject)
        {
            Console.WriteLine("Cannot play media file.");
        }
        public  void PlayCommercial(string file)
        {
            player.URL = file;
        }
        public void PauseMusic(string file)
        {
            
        }

        public void StopMusic()
        {
            
        }
       
        public void Volume()
        {
            Console.WriteLine("Geef aan met 'up' of 'down' of u uw volume wil verhogen of verlagen");//volume regelen
            string volumeUpDown = Console.ReadLine();
            while (player.settings.volume != 0)
            {
                volumeUpDown = Console.ReadLine();
                switch (volumeUpDown)//switch om volume te verhogen of verlagen
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

        public void VolumeUp()
        {
          
            if (player.settings.volume < 90)
            {
                player.settings.volume = player.settings.volume + 5;
            }
        }

        public void VolumeDown()
        {
            
            if (player.settings.volume > 1)
            {
                player.settings.volume = player.settings.volume - (player.settings.volume / 2);
            }
        }

        public  void Error()
        {
            Console.WriteLine("Geen geldige invoer!");
        }


    }
}
