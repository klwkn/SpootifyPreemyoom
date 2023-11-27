using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spootefee
{
    public class NodeFavorites<F>
    {
        public F FData { get; set; }
        public NodeFavorites<F> Next { get; internal set; }
        public NodeFavorites(F fdata)
        {
            this.FData = fdata;
        }
    }
}
