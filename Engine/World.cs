using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class World
    {
        public static void WorldMap()
        {
            var worldMap = new int[4, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };
        }
    }
}
