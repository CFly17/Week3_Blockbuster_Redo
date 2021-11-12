using System;
using System.Collections.Generic;

namespace Week3_BlockbusterLab
{
    class Movie
    {
        //Scenes
        public List<string> Scenes = new List<string>() { "Intro", "Second part", "Third part", "Climax", "Denouement", "Finale" };
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }


        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;

        }

        public Movie()
        {
        }

        public virtual void PrintInfo()
        {
            List<Movie> list = Blockbuster.GetMovies();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {list[i].Title} ({list[i].Category})\n\tRuntime: {list[i].RunTime} minutes");
                Console.WriteLine();
            }
        }

        //PRINT ALL SCENES + THEIR INDEX
        public virtual void SelectMovie()
        {
            Blockbuster b = new Blockbuster();
            List<Movie> list = Blockbuster.GetMovies();
            List<string> scenes = new List<string>() { "Intro", "Second part", "Third part", "Climax", "Denouement", "Finale" };
            Console.WriteLine("What movie would you like to watch?\n");
            for (int i = 0; i < scenes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Title: {list[i].Title}");
            }
            int response = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Which scene would you like to start {list[response].Title} at?");
            Console.WriteLine();
            for (int i = 0; i < scenes.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {scenes[i]}");
            }
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Starting {list[response].Title} at the {scenes[userInput-1]}. Enjoy!");
        }

        public void SelectScene()
        {
            List<Movie> list = Blockbuster.GetMovies();
            List<string> scenes = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scenes[i + 1]}");
            }
        }

        public virtual void Play()
        {
        }

        public override string ToString()
        {
            string output = $"Title: {Title}\n" +
                $"Category: {Category}\n" +
                $"Runtime: {RunTime}";
            return output;
        }
    }

}
