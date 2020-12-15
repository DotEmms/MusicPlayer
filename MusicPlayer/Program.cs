using System;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Musify ********");//toon titel muziekspeler
            string pathCommercial = "C:/Music/Commercial.mp3";
            Music.PlayCommercial(pathCommercial);//reclame
            Music.PlayMusic(Music.GetMusicFile());//muziek
            Console.ReadLine();
            Music.Volume();
        }
    }
}
