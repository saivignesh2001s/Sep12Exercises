using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep12Exercises
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class Stereodisc : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        //readonly string positionalString;

        // This is a positional argument
        public Stereodisc (string sname, string slanguage, string slyrics)
        {
            //this.positionalString = positionalString;

            // TODO: Implement code here
            this.songname = sname;
            this.slanguage = slanguage;
            this.slyrics = slyrics;
                //throw new NotImplementedException();
        }

        //public string PositionalString
        //{
        //    get { return positionalString; }
        //}

        // This is a named argument
        
        public string songname { get; }
        public string slanguage { get;  }
        public string slyrics { get; }

    }
}
