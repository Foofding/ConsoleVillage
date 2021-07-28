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
        public char[] cells;
        private char[] cells2;

        public WorldGrid(int w, int h)
        {
            width = w;
            height = h;
            cells = new char[width * height];
            cells2 = new char[width * height];
            for (int i = 0; i < cells.Length; i++)
                cells[i] = '-';
            for (int i = 0; i < cells2.Length; i++)
                cells2[i] = '-';
        }

        public void Displaygrid()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                if (i % width == 0 && i != 0)
                {
                    Console.WriteLine("");
                }
                //if (cells[i] == '@')
                //{
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.Write(cells[i]);
                //    Console.ForegroundColor = ConsoleColor.White;
                //}
                 Console.Write(cells[i]);
            }
        }

        public char GetCell(int x, int y)
        {
            if (y >= height) y = 0;
            if (y < 0) y = height - 1;
            if (x >= width) x = 0;
            if (x < 0) x = width - 1;
            return cells[y * width + x];
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
