using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceFightServer
{
    public class Constants
    {
        public const int MAX_PLAYERS = 100;
        public static string TimeStamp()
        { return DateTime.Now.ToLongTimeString() + " --- "; }

    }
}
