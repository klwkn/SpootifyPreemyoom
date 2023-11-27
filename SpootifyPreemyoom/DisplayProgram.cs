using System;
using Spootefee;
namespace SpootifyLinkedLists
{
    public class HopOutThe125
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ramon's Playlist!");
            LinkedListMain<string> mainPlaylist = new LinkedListMain<string>();
            LinkedListFavorites<string> favoritesPlaylist = new LinkedListFavorites<string>();

            Console.WriteLine("\nRamon's main music playlist");
            mainPlaylist.traverseMain();
            Console.WriteLine(mainPlaylist.Count == 0 ? "none" : "");

            Console.WriteLine("\nRamon's favorite music playlist");
            favoritesPlaylist.traverseFav();
            Console.WriteLine(favoritesPlaylist.Count == 0 ? "none" : "");

            Console.Write("\nHow many songs do you want to add to Ramon's playlist?: ");
            if (!int.TryParse(Console.ReadLine(), out int numSongs) || numSongs <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive number of songs.");
                return;
            }

            for (int i = 0; i < numSongs; i++)
            {
                Console.Write("Insert Song: ");
                string song = Console.ReadLine();
                mainPlaylist.MainAddLast(new NodeMain<string>(song));
            }

            Console.WriteLine("\nRamon's main music playlist");
            mainPlaylist.traverseMain();

            Console.Write("Would you like to add a song? [y/n]: ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Write("Where do you want to add the song?\n" +
                              "a. Between\n" +
                              "b. Last\n" +
                              "Answer: ");
                string addOption = Console.ReadLine();
                if (addOption == "a")
                {
                    Console.Write("Name of song to put it between: ");
                    string existingSong = Console.ReadLine();
                    Console.Write("Name of song to be added: ");
                    string newSong = Console.ReadLine();
                    mainPlaylist.MainAddAfter(new NodeMain<string>(newSong), mainPlaylist.findSong(existingSong));
                }
                else if (addOption == "b")
                {
                    Console.Write("Name of song: ");
                    string newSong = Console.ReadLine();
                    mainPlaylist.MainAddLast(new NodeMain<string>(newSong));
                }
            }

            Console.WriteLine("\nRamon's main music playlist");
            mainPlaylist.traverseMain();

            Console.Write("Would you like to transfer a song from your main list to your favorite list? [y/n]: ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.Write("What song you want to transfer?\n" +
                              "a. First song\n" +
                              "b. Specify song\n" +
                              "c. Last song\n" +
                              "Answer: ");
                string transferOption = Console.ReadLine();
                if (transferOption == "a")
                {
                    favoritesPlaylist.AddFavFirst(mainPlaylist);
                }
                else if (transferOption == "b")
                {
                    Console.Write("Name of song to transfer: ");
                    string songToTransfer = Console.ReadLine();
                    favoritesPlaylist.AddFavSpecific(mainPlaylist, songToTransfer);
                }
                else if (transferOption == "c")
                {
                    favoritesPlaylist.AddFavLast(mainPlaylist);
                }
            }

            Console.WriteLine("\nRamon's main music playlist");
            mainPlaylist.traverseMain();

            Console.WriteLine("\nRamon's favorite music playlist");
            favoritesPlaylist.traverseFav();

            // End of the program
        }
    }
}