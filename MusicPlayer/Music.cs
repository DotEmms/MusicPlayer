using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace MusicPlayer
{
    class Music
    {
        static void MusicPlayer()
        {
            //commentaar
        }


        public static string GetMusicFile()
        {
            Console.Write("Geef de titel van het liedje in: ");
            string input = Console.ReadLine(); //lees user input (titel)
            string path = "C:/Music/" + input + ".mp3";//aangegeven pad voor het bestand
            Console.WriteLine($"Now playing {input}");
            return path;
        }
        public static void PlayMusic(string file)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = file;
        }

        public static void PlayCommercial(string file)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = file;
        }
        public static void PauseMusic(string file)
        {
            throw new NotImplementedException();
        }

        public static void StopMusic(string file)
        {
            throw new NotImplementedException();
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
                player.settings.volume = player.settings.volume + 5;
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


    }
}
