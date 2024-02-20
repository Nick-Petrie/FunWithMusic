using System;
using System.Reflection;
using System.Threading.Channels;

namespace music
{
    class Program
    {
        enum Genre
        {
            Rock,
            Pop,
            Emo,
            Alternative,
            HeavyMetal,
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre Genre;
            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display() {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length +
                       "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the name of the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How long is the song?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What genre of music?");
            Console.WriteLine("R - Rock\nP - Pop\nE - Emo\nA - Alternative\nH - Heavy Metal");
            Genre tempGenre = Genre.Rock;

            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'E':
                    tempGenre = Genre.Emo;
                    break;
                case 'A':
                    tempGenre = Genre.Alternative;
                    break;
                case 'H':
                    tempGenre = Genre.HeavyMetal;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Music moreMusic = music;
            moreMusic.setTitle("Smahckked My Head Awf");
            moreMusic.setLength("3 minutes and 8 seconds");
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine("What is the next song on the album?");
            Console.WriteLine("How long it the song?");
            Console.WriteLine($"{moreMusic.Display()}");

        }
    }

}