using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            MyChess my = new MyChess();
            while (!my.ChessOver)
            {
                my.Pole(my.ChessOver);
                my.ChooseFigure();
            }
        }
    }
}
