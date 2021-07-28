using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleVillage.WorldGrid;

namespace ConsoleVillage.Structures
{
    class House
    {

    }

    public void DrawHouse(char[] worldGrid, int x, int y)
    {
        //Origin point is not left. House is 3x3 111101 (1 = wall, 0 = door)
        (WorldGrid.GetCell(x - 1, y - 1)
        WorldGrid.GetCell(x + 1,y)
        WorldGrid.GetCell(x+2,y)
        WorldGrid.GetCell(x, y)
        WorldGrid.GetCell(x, y)
        WorldGrid.GetCell(x, y)



        worldGrid[] = 219

    }

}
