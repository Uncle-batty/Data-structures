using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucutres
{
    public class UseQueues
    {
        List<Song> allSongs = new List<Song>
{
    new Song { Id = 0, Title = "Blinding Lights", Artist = "The Weeknd", Length = "3:20", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b"},
    new Song { Id = 1, Title = "Shape of You", Artist = "Ed Sheeran", Length = "3:53", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b" },
    new Song { Id = 2, Title = "Bad Guy", Artist = "Billie Eilish", Length = "3:14" , Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b"},
    new Song { Id = 3, Title = "Levitating", Artist = "Dua Lipa", Length = "3:23", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b" },
    new Song { Id = 4, Title = "Bohemian Rhapsody", Artist = "Queen", Length = "5:55", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b" },
    new Song { Id = 5, Title = "Uptown Funk", Artist = "Mark Ronson ft. Bruno Mars", Length = "4:30", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b" },
    new Song { Id = 6, Title = "Smells Like Teen Spirit", Artist = "Nirvana", Length = "5:01", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b" },
    new Song { Id = 7, Title = "Rolling in the Deep", Artist = "Adele", Length = "3:48", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b" },
    new Song { Id = 8, Title = "Take On Me", Artist = "a-ha", Length = "3:46", Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b" },
    new Song { Id = 9, Title = "Billie Jean", Artist = "Michael Jackson", Length = "4:54" , Url = "https://open.spotify.com/track/0VjIjW4GlUZAMYd2vXMi3b"}
};

        Queue<Song> Songs;

        public UseQueues()
        {
            Songs = new Queue<Song>();
        }

        public void AddSong(int id)
        {
            if (id >= 0 && id < allSongs.Count)
                Songs.enqueue(allSongs[id]);
            else
                Console.WriteLine("Invalid song ID.");
        }

        public Song Playsongs()
        {

            var currentSong = Songs.getHead();

            Console.WriteLine(currentSong.Title);
            Process.Start(new ProcessStartInfo
            {
                FileName = currentSong.Url,
                UseShellExecute = true
            });

            Songs.dequeue();
            return currentSong;

        }
    }

    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Length { get; set; }
        public string Url { get; set; }
    }

}
