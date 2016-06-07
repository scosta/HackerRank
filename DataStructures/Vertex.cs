using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures
{
    public class Vertex
    {
        public int ID { get; set; }
        public bool Discovered { get; set; }
        public bool Processed { get; set; }
        public Vertex Parent { get; set; }
    }
}
