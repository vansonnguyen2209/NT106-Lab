using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Packet
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<int> Pos = new List<int>();
    }
}
