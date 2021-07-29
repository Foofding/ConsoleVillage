using ConsoleVillage.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVillage
{
    public class WorldGrid
    {
        private int width;
        private int height;
        private char[] Cells2;

        public char[] Cells;       
        public List<House> Houses;
       


        public WorldGrid()
        {

        }

        public WorldGrid(int w, int h)
        {
            width = w;
            height = h;
            Cells = new char[width * height];
           //Cells2 = new char[width * height];
            for (int i = 0; i < Cells.Length; i++)
                Cells[i] = '-';
           // for (int i = 0; i < Cells2.Length; i++)
           //     Cells2[i] = '-';
        }
        

        public void DisplayGrid()
        {
            for (int i = 0; i < Cells.Length; i++)
            {
                if (i % width == 0 && i != 0)
                {
                    Console.WriteLine("");
                }
                //if (Cells[i] == '@')
                //{
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.Write(Cells[i]);
                //    Console.ForegroundColor = ConsoleColor.White;
                //}
                 Console.Write(Cells[i]);
            }
        }

        public char GetCell(int x, int y)
        {
            if (y >= height) y = 0;
            if (y < 0) y = height - 1;
            if (x >= width) x = 0;
            if (x < 0) x = width - 1;
            return Cells[y * width + x];
        }

        public int GetNeighbors(int x, int y)
        {
            int count = 0;
            //Top left
            if (GetCell(x - 1, y - 1) != '-') count++;
            //Top middle
            if (GetCell(x, y - 1) != '-') count++;
            //Top right
            if (GetCell(x + 1, y - 1) != '-') count++;
            //middle left
            if (GetCell(x - 1, y) != '-') count++;
            //middle right
            if (GetCell(x + 1, y) != '-') count++;
            //bottom left
            if (GetCell(x - 1, y + 1) != '-') count++;
            //bottom middle
            if (GetCell(x, y + 1) != '-') count++;
            //bottom right
            if (GetCell(x + 1, y + 1) != '-') count++;  
           
            return count;
        }
        




    }
}
