namespace Playlisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Our object
            Playlist playlist = new Playlist();
            //Variable for the song name
            string songName;
            
            //User interface
            Console.WriteLine("Hvor mange sange vil du tilføje?");
            int numberOfSongs = int.Parse(Console.ReadLine());

            //For loop to choose how many songs the user wants
            for (int i = 0; i < numberOfSongs; i++)
            {
                //So the user can add a song
                Console.WriteLine("Skriv navnet på en sang du vil føje til din playlist");
                songName = Console.ReadLine();
                playlist.AddSong(songName);
            }
            

            Console.WriteLine("Her er din playlist\r\n");
            

            foreach (Track track in playlist.tracks)
            {
                //Write the track names in console
                Console.WriteLine(track.Name);
            }
        }
        public class Track
        {
            //Instance variable
            private string name;
            
            //incapsulation
            public string Name
            {
                get { return name; }
            }
            //Constructor
            public Track(string name)
            {
                this.name = name;
            }
        }
        internal class Playlist
        {
            //Linked list
            public LinkedList<Track> tracks = new LinkedList<Track>();
            public void AddSong(string name)
            {
                //Adds the song to the last spot
                Track track = new Track(name);
                tracks.AddLast(track);
            }
        }
    }
}