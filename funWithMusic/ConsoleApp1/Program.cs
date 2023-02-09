using System;
using static System.Console;

namespace funWithMusic
{
    class Program
    {
        enum Genre {Rap, Metal, Electronic, Classical, KPop}
        struct Music
        {
            public string Title;
            public string Artist;
            public string Album;
            public int Length;
            public Genre Genre; 

            public Music(string title, string artist, string album, int length, Genre genre)
            {
                Title= title;
                Artist= artist;
                Album= album;
                Length= length;
                Genre= genre;
            }

            public void displaySongs()
            {
                WriteLine($"Title: {Title} Artist: {Artist} Album: {Album} Legnth: {Length} minutes Genre: {Genre}");
            }

            public void setTitle(string title) { Title= title; } 
            public void setLength(int length) { Length= length; }

        }
        static void Main(string[] args)
        {
            string title, artist, album;
            Genre genre= Genre.Rap;
            int length;
            WriteLine("Please enter the song title: ");
            title= ReadLine();
            WriteLine("Please enter the song artist: ");
            artist= ReadLine();
            WriteLine("Please enter the song album: ");
            album= ReadLine();
            WriteLine("Please enter the song length: ");
            length = int.Parse(ReadLine());
            WriteLine("Please enter the song genre:R for Rap, M for Metal, E for Electronic, C for Classical or K for Kpop ");
            string tempGenre = ReadLine();
            tempGenre.ToUpper();
            switch (tempGenre)
            {
                case "R":
                    genre = Genre.Rap;
                    break;
                case "M":
                    genre= Genre.Metal;
                    break;
                case "E":
                    genre=Genre.Electronic; 
                    break;
                case "C":
                    genre = Genre.Classical;
                    break;
                case "K":
                    genre = Genre.KPop;
                    break;
            }
            Music songOne= new Music(title, artist, album,length,genre);
            Music moreMusic = songOne;
            WriteLine($"What is the next song on the {album} album: ");
            title= ReadLine();
            moreMusic.setTitle(title);
            WriteLine("What is the Legnth of the second song: ");
            length= int.Parse(ReadLine());
            moreMusic.setLength(length);
            songOne.displaySongs();
            moreMusic.displaySongs();
        }
    }
}