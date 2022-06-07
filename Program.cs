using System;

namespace TheFourSistersandtheDuckbear
{
    class Program
    {
        static void Main(string[] args)
        {
             int chocolateEggs;
             int girlsEggs;
             int duckBearEggs;

             Console.WriteLine("How many chocolate eggs did you girls collect today?");
             chocolateEggs = Convert.ToInt32(Console.ReadLine());


             duckBearEggs = chocolateEggs % 4;
             girlsEggs = (chocolateEggs - duckBearEggs) / 4;

             Console.WriteLine("Girls, you each get " + girlsEggs + " chocolate eggs today...");

             Console.WriteLine("And Duckbear gets: " + duckBearEggs + " chocolate eggs today!");
        }
    }
}
