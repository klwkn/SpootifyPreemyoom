using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spootefee
{
    public class LinkedListMain<T>
    {
        public NodeMain<T> First { get; set; }
        public NodeMain<T> Last { get; set; }
        public int Count { get; set; }
        public LinkedListMain()
        {
            this.First = null;
            this.Last = null;
        }
        public void MainAddSong(NodeMain<T> mainNode)
        {
            if (this.First == null)
            {
                this.First = mainNode;
                this.Last = mainNode;
            }
            else
            {
                mainNode.Next = this.First;
                this.First = mainNode;
            }
            Count++;
        }
        public void MainAddAfter(NodeMain<T> mainNode, NodeMain<T> nowNode)
        {
            if (this.Last == nowNode)
            {
                Last = mainNode;
            }
            mainNode.Next = nowNode.Next;
            nowNode.Next = mainNode;
            this.Count++;
        }
        public void MainAddLast(NodeMain<T> mainNode)
        {
            if (this.First == null)
            {
                this.First = mainNode;
                this.Last = mainNode;
            }
            else
            {
                this.Last.Next = mainNode;
                this.Last = mainNode;
            }
            Count++;
        }
        public NodeMain<T> findSong(T targetSong)
        {
            NodeMain<T> currentNode = First;
            while (currentNode != null && !currentNode.TData.Equals(targetSong))
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }
        public void RemoveFirst()
        {
            if (First == null || this.Count == 0)
            {
                return;
            }
            First = First.Next;
            this.Count--;
        }
        public void RemoveLast()
        {
            if (this.First == null || this.Count == 0)
            {
                return;
            }
            if (this.First == this.Last)
            {
                this.First = null;
                this.Last = null;
            }
            else
            {
                NodeMain<T> current = this.First;
                NodeMain<T> previous = null;

                while (current.Next != null)
                {
                    previous = current;
                    current = current.Next;
                }

                previous.Next = null;
                this.Last = previous;
            }
            this.Count--;
        }
        public void Remove(NodeMain<T> doomedSongNode)
        {
            if (First == null || this.Count == 0)
            {
                return;
            }
            if (this.First == doomedSongNode)
            {
                this.RemoveFirst();
                return;
            }
            NodeMain<T> previous = First;
            NodeMain<T> current = previous.Next;
            while (current != null && current != doomedSongNode)
            {
                previous = current;
                current = previous.Next;
            }
            if (current != null)
            {
                previous.Next = current.Next;
                this.Count--;
            }
        }
        public void traverseMain()
        {
            if (First == null)
            {
                return;
            }
            Console.WriteLine("\nFirst Song: " + First.TData);
            Console.WriteLine("Last: " + Last.TData);
            NodeMain<T> noode = this.First;
            while (noode.Next != null)
            {
                Console.WriteLine(noode.TData);
                noode = noode.Next;
            }
            Console.WriteLine(noode.TData);
        }
    }
}
