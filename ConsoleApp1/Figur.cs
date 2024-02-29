using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Figur
    {
        string name;

        int x1;
        int y1;

        int x2;
        int y2;

        int x3;
        int y3;

        public Figur(int x1,int y1,int x2,int y2,int x3,int y3)
        {
            this.x1 = x1;
            this.y1 = y1;

            this.x2 = x2;
            this.y2 = y2;

            this.x3 = x3;
            this.y3 = y3;
        }

        public int X1 { get => x1;  }
        public int Y1 { get => y1; }
        public int X2 { get => x2;}
        public int Y2 { get => y2;}
        public int X3 { get => x3;}
        public int Y3 { get => y3;}
    }
}
