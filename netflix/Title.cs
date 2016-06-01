using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Title
    {
        public string name;
        public int? rating;
        Genre genre;
        public Title()
        {
            name = null;
            rating = null;
            genre = null;
        }
        public Title(string name, int rating, Genre genre)
        {
            this.name = name;
            this.rating = rating;
            this.genre = genre;
        }

        public static Genre operator +(Title title1, Title title2)
        {
            return new Genre(title1.genre.name + ", " + title2.genre.name);
        }

        //Title
        //- Name field
        //- Rating field
        //- Overload plus(+) operator to take in two Titles and return an aggregated Genre
        //-Offer two overloaded constructors: one that takes in all the fields and sets them, another that takes in no fields and 
        //sets the internal fields to null.

    }
}
