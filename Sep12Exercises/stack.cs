using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep12Exercises
{
    [Stereodisc("songname","language","lyrics")]
   public class song
    {
        [Stereodisc("Kannalane", "tamil", "lyrics")]
        public string sName
        {
            get;
            set;
        }
        [Stereodisc("Aadungada","tamil","lyrics")]
        public int Count
        {
            get;
        }


    }
}
