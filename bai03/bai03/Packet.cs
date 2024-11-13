using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai03
{
    internal class Packet
    {
        public List <string> image { get; set; }
        public List<string>  audio { get; set; }
        public List <string> script {  get; set; }
        public List<string> css { get; set; }
    }
}
