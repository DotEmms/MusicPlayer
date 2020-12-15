using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            [STAThread]

            Console.WriteLine("******** Musify ********");//toon titel muziekspeler
            string input = Console.ReadLine(); //lees user input (titel)
            string path = "C:/Music/" + input + ".mp3";//aangegeven pad voor het bestand
            string pathCommercial = "C:/Music/Commercial.mp3";
            MusicPlayer2.PlayCommercial(pathCommercial);//reclame
            MusicPlayer2.PlayMusic(path);//muziek
            Console.WriteLine($"Now playing {input}");//teruggave van de user keuze
            Console.ReadLine();
            MusicPlayer2.Volume();

        }
    }
}
