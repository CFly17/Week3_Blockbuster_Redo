using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_BlockbusterLab
{
    class Blockbuster 
    {
            //If we declare MoviesList as a property here,
            //we then have to create an object.
        public List<Movie> MoviesList { get; set; } = new List<Movie>();


        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>();
            List<string> scenes = new List<string>() { "Intro", "Second part", "Third part", "Climax", "Denouement", "Finale" };
            movieList.Add(new DVD("Terrifier", Genre.Horror, 86, scenes));
            movieList.Add(new DVD("Hellraiser", Genre.Horror, 94, scenes));
            movieList.Add(new DVD("Gone with the Wind", Genre.Drama, 238, scenes));
            movieList.Add(new VHS("Pineapple Express", Genre.Comedy, 117, scenes, 0));
            movieList.Add(new VHS("Pirates of the Caribbean", Genre.Action, 143, scenes, 0));
            movieList.Add(new VHS("The Notebook", Genre.Romance, 124, scenes, 0));

            return movieList;
        }
    }
}
