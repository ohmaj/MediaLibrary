using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Genre
    {
        public string name;
        List<Title> Titles;
        public Genre(string name)
        {
            this.name = name;
        }
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            return new Genre(genre1.name + ", " + genre2.name);
        }
        public static Genre operator +(Title title1, Genre genre1)
        {
            Genre appendedGenre = genre1;
            appendedGenre.Titles.Add(title1);
            return appendedGenre;
        }
        //Genre
        //-    Contains a list of Titles
        //-    Implement custom iterator to iterate over those Titles
        //-    Overload plus(+) operator to take in two Genres and return the aggregated Genre.
        //o For example, if we want to create an aggregated genre Romantic Comedy, all the film titles in that specific genre 
        //would include film titles from Romance and film titles from Comedy.
        //-    Overload plus (+) operator to take in a Genre and a Title to return the aggregated Genre.
        //o Take in a title, add it to the genre, return an aggregated list.
        //o For example, title Die Hard and genre Comedy would return a list of all comedy films and Die Hard.
        //

    }
}
