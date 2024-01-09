using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Constructeur sans paramètre
        public Point()
        {
        }

        // Constructeur qui accepte deux arguments
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}