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
            Console.Write("Type the title of the song: ");
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
                player.controls.stop();
            }
        }


        private void Player_MediaError(object pMediaObject)
        {
            Console.WriteLine("Cannot play media file.");
            player.controls.stop();
        }
        public  void PlayCommercial(string file)
        {
            player.URL = file;
        }
        public void ControlMusic()
        {
            Console.WriteLine("Enter 'stop' to stop the song, 'pause/pauze' to pause the song and 'play' to commence:");
            string controlMusic = Console.ReadLine();
            while (player.playState != WMPPlayState.wmppsStopped)
            {
                switch (controlMusic.ToLower())
                {
                    case "stop":
                        {
                            player.controls.stop();
                            break;
                        }
                   
                    case "pause":
                    case "pauze":
                    
                        {
                            if (player.playState == WMPPlayState.wmppsPaused)
                            {
                                player.controls.play();
                            }
                            else if (player.playState == WMPPlayState.wmppsPlaying)
                            {
                                player.controls.pause();
                            }
                            break;
                        }
                    case "play":
                        {
                            if (player.playState == WMPPlayState.wmppsStopped)
                            {
                                player.controls.play();
                            }
                            else if(player.playState == WMPPlayState.wmppsPaused)
                            {
                                player.controls.play();
                            }
                            else
                            {
                                Error();
                            }
                            break;
                        }
                    
                    default:
                        {
                            Error();
                            break;
                        }
                }
            }
        }

               
        public void Volume()
        {
            Console.WriteLine("Enter 'up' or 'down' to alter the volume, 'stop' to close the volume menu.");//volume regelen => moet nog naar het Engels
            string volumeUpDown = Console.ReadLine();
            while (player.settings.volume != 15)
            {
                volumeUpDown = Console.ReadLine();
                switch (volumeUpDown.ToLower())//switch om volume te verhogen of verlagen
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
                    case "stop":
                        {
                            player.settings.volume = 15;
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
            Console.WriteLine("No valid entry!");
        }


    }
}
