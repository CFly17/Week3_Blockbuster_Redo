using System;

namespace Week3_BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            Movie m = new Movie();
            Console.WriteLine("Welcome to Blockbuster!\n");

            while (goOn == true)
            {
                Console.WriteLine("\tMAIN MENU");
                Console.WriteLine("[1]Print movies\n[2]Select movie to watch\n[3]Quit");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        m.PrintInfo();
                        break;
                    case 2:
                        m.SelectMovie();
                        break;
                    case 3:
                        Console.WriteLine("See you!");
                        goOn = false;
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        break;
                }
            }

        }
    }
}
