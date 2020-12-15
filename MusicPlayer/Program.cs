using System;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Music player = new Music();
            Console.WriteLine("******** Musify ********");//toon titel muziekspeler
            string pathCommercial = "C:/Music/Commercial.mp3";
            player.PlayCommercial(pathCommercial);//reclame
            player.PlayMusic(player.GetMusicFile());//muziek
            Console.ReadLine();
            player.Volume();//volume aanpassen
        }
    }
}
