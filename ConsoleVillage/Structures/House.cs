using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleVillage;

namespace ConsoleVillage.Structures
{
    public class House
    {
        private int x;
        private int y;

        public House(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get; set; }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void DrawHouse(WorldGrid worldgrid, int x, int y)
        {

            //worldGrid[worldGrid.GetCell(x - 1, y - 1)] = '\x0219';
            //worldGrid[GetCell(x, y - 1)] = '\x0219';
            //worldGrid[GetCell(x + 1, y - 1)] = '\x0219';
            //worldGrid[GetCell(x - 1, y)] = '\x0219';
            //worldGrid[GetCell(x, y)] = '\x0219';
            //worldGrid[GetCell(x + 1, y)] = '\x0219';
            //worldGrid[GetCell(x - 1, y + 1)] = '\x0219';
            //worldGrid[GetCell(x, y + 1)] = '\x0219';
            //worldGrid[GetCell(x + 1, y + 1)] = '\x0219';
        }


    }

   



}
