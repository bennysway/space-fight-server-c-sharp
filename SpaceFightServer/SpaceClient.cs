using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFightServer
{
    public class SpaceClient
    {
        public string _index { get; set; }
        public string _id { get; set; }
        public string _username { get; set; }
        public bool isGaming { get; set; }

        public SpaceClient(string index)
        {
            _index = index;
        }

    }
}
