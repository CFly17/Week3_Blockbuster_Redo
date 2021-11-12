using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_BlockbusterLab
{
    class DVD : Movie
    {

        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes)
            : base (Title, Category, RunTime, Scenes)
        {

        } 
        
        public int CurrentTime { get; set; }

        public override void Play()
        {
            Console.WriteLine($"What scene of {Title} would you like to play?");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"You've selected scene {Scenes[input-1]}. Enjoy!");
        }
    }
}
