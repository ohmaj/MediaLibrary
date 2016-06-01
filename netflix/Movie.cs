using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Movie: Title
    {
        int duration;
        public override string ToString()
        {
            string newString = name + ", " + duration.ToString() + " minutes.";
            return newString;
        }
        //Movie(Inherits from Title)
        //-    Duration field
        //-    Overrides ToString() method to return a string of the name and duration of the movie
    }
}
