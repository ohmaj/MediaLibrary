using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflix
{
    class Show: Title
    {
        List<Episode> episodes;
        new int rating;
        public Show(List<Episode> episodes)
        {
            this.episodes = episodes;
            this.rating = getAvgRating();
        }

        public int getAvgRating()
        {
            int sum = 0;
            int count = 0;
            foreach (Episode episode in this.episodes)
            {
                sum = sum + episode.rating;
                count = count + 1;
            }
            int average = sum / count;
            return average;
        }
        public override string ToString()
        {
            string newString = name + ", " + episodes.Count().ToString() + " episodes.";
            return newString;
        }
        //Show(inherits from Title)
        //-    Contains a list of Episodes
        //-    Overrides parent’s Rating to return an aggregated rating of Episode ratings
        //-    Overrides ToString() method to return a string of the name of the show and number of episodes
    }
}
