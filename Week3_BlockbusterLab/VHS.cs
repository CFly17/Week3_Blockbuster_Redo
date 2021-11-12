using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes, int CurrentTime)
            : base(Title, Category, RunTime, Scenes)
        {
            this.CurrentTime = CurrentTime;
        }

        //Method to increment playtime

        //Method to set CurrentTime to 0
        public void Rewind()
        {
            CurrentTime = 0;
        }

        public override void Play()
        {
            PrintInfo();
            List<Movie> list = Blockbuster.GetMovies();
            Console.WriteLine("What scene would you like to play?");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i+1}. ");
            }

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Great! We'll start the movie at the {list[input].Scenes}.");
        }
    }
}
