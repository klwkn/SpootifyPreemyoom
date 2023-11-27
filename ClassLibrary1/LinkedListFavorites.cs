using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spootefee
{
    public class LinkedListFavorites<F>
    {
        public NodeFavorites<F> First { get; set; }
        public NodeFavorites<F> Last { get; set; }
        public int Count { get; set; }
        public LinkedListFavorites()
        {
            this.First = null;
            this.Last = null;
        }
        public void AddSongMethod(F song)
        {
            NodeFavorites<F> newNode = new NodeFavorites<F>(song);
            if (this.First == null)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }
        public void AddFavFirst(LinkedListMain<F> mainPlaylist)
        {
            NodeMain<F> mainNode = mainPlaylist.First;
            if (mainNode != null)
            {
                mainPlaylist.RemoveFirst();
                AddSongMethod(mainNode.TData);
            }
            else
            {
                Console.WriteLine("Main playlist is empty. Cannot transfer the first song.");
            }
        }
        public void AddFavSpecific(LinkedListMain<F> mainPlaylist, F song)
        {
            NodeMain<F> mainNode = mainPlaylist.findSong(song);
            if (mainNode != null)
            {
                mainPlaylist.Remove(mainNode);
                AddSongMethod(mainNode.TData);
            }
            else
            {
                Console.WriteLine($"Invalid Input! Song '{song}' not found in main playlist");
            }
        }
        public void AddFavLast(LinkedListMain<F> mainPlaylist)
        {
            NodeMain<F> mainNode = mainPlaylist.Last;
            if (mainNode != null)
            {
                mainPlaylist.RemoveLast();
                AddSongMethod(mainNode.TData);
            }
            else
            {
                Console.WriteLine("Main Playlist is empty. Cannot transfer last song.");
            }
        }
        public void traverseFav()
        {
            if (First == null)
            {
                return;
            }
            Console.WriteLine("\nFirst Song: " + First.FData);
            Console.WriteLine("Last: " + Last.FData);
            NodeFavorites<F> node = this.First;
            while (node.Next != null)
            {
                Console.WriteLine(node.FData);
                node = node.Next;
            }
            Console.WriteLine(node.FData);
        }
    }
}
