using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;

namespace MusicPlayer
{
    class MusicList
    {
        List<string> musicList = new List<string>();

        public List(List<string> musicList)
        {
            this.musicList = musicList;
            musicList.Add("C:/Music/Commercial.mp3");
            musicList.Add("C:/Music/Waterloo.mp3");
            musicList.Add("C:/Music/Pokerface.mp3");
            musicList.Add("C:/Music/Perfect.mp3");
            Console.WriteLine(musicList);
        }
    }
}
