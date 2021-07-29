using ConsoleVillage.Structures;
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
            Console.WindowWidth = 141;
            Console.WindowHeight = 63;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            WorldGrid world = new WorldGrid(140, 63);
            House house = new House(50, 50);            
            // var home1 = new House();
            //home1.DrawHouse(world.cells, 1, 1);
            // world.DrawHouse(world.cells, 1, 1);         
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            world.DisplayGrid();
            Console.ReadLine();

        }
    }
}
