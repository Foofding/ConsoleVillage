using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVillage
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldGrid world = new WorldGrid(140, 63);
            Console.WindowWidth = 141;
            Console.WindowHeight = 63;
            Console.BackgroundColor = ConsoleColor.Green;
            world.Displaygrid();
            Console.ReadLine();
        }
    }
}
