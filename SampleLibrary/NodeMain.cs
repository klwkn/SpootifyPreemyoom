using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpootifyLinkedLists
{
    public class NodeMain<T>
    {
        public T TData { get; set; }
        public NodeMain<T> Next { get; internal set; }
        public NodeMain(T tdata)
        {
            this.TData = tdata;
        }
    }
}
