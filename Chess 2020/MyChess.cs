using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class MyChess
    {
        public bool ChessOver = false;
        public int x = 0, y = 0, i = 0, z = 0;
        public ConsoleKeyInfo knopki;
        public string[,] MyBoard = new string[,]
        {
            { "\u265c ","\u265e ","\u265d ", "\u265b ", "\u265a ", "\u265d ", "\u265e ", "\u265c " , " 8" },
            { "\u265F ","\u265F ","\u265F ", "\u265F ", "\u265F ", "\u265F ", "\u265F ", "\u265F " , " 7" },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " , " 6"  },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " , " 5"  },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " , " 4"  },
            { "  ","  ","  ", "  ", "  ", "  ", "  ", "  " , " 3"  },
            { "\u2659 ", "\u2659 ","\u2659 ", "\u2659 ", "\u2659 ", "\u2659 ", "\u2659 ", "\u2659 " , " 2" },
            { "\u2656 ", "\u2658 ","\u2657 ", "\u2655 ", "\u2654 ", "\u2657 ", "\u2658 ", "\u2656 " , " 1" },
            //{ "H ", "G ","F ", "E ", "D ", "C", "B ", "A " }
        };
        public bool Pole(bool ChessOver)
        {
            for (int i = 0; i < MyBoard.GetLength(0); i++)
            {
                for (int j = 0; j < MyBoard.GetLength(1); j++)
                {
                    if ((j + i) % 2 == 0 && j < 8 && i < 8)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(MyBoard[i, j]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(MyBoard[i, j]);
                    }
                }
                Console.WriteLine();
            }
            return ChessOver;
        }
        public void ChooseFigure()
        {
            while (true)
            {
                if (Console.KeyAvailable == true)
                { knopki = Console.ReadKey(true); }
                switch (knopki.Key)
                {
                    case ConsoleKey.W:
                        if (y > 0)
                        {
                            y--;
                            Console.SetCursorPosition(x, y);
                        }
                        break;
                    case ConsoleKey.A:
                        if (x > 0)
                        {
                            x -= 2;
                            Console.SetCursorPosition(x, y);
                            z--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (y < 7)
                        {
                            y++;
                            Console.SetCursorPosition(x, y);
                        }
                        break;
                    case ConsoleKey.D:
                        if (x < 14)
                        {
                            x += 2;
                            Console.SetCursorPosition(x, y);
                            z++;
                        }
                        break;
                }
            }
        }
        public void Peshki()
        {
            while (true)
            {
                if (x == 0 && y == 6 || x == 2 && y == 6 || x == 4 && y == 6 || x == 6 && y == 6 || x == 8 && y == 6 || x == 10 && y == 6 || x == 12 && y == 6 || x == 14 && y == 6)
                {
                    int j = 0;
                    knopki = Console.ReadKey(true);
                    switch (knopki.Key)
                    {
                        case ConsoleKey.W:
                            if ((((x - z) + y) % 2) != 0)
                            { Console.BackgroundColor = ConsoleColor.Black; }
                            else
                            { Console.BackgroundColor = ConsoleColor.White; }
                            MyBoard[y, (x - z)] = "  ";
                            Console.SetCursorPosition(x, y);
                            Console.Write(MyBoard[y, (x - z)]);
                            y--;
                            Console.SetCursorPosition(x, y);
                            MyBoard[y, (x - z)] = "\u2659 ";
                            if ((((x - z) + y) % 2) == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Write(MyBoard[y, (x - z)]);
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write(MyBoard[y, (x - z)]);
                            }
                            j++;
                            break;
                    }
                }
            }
        }

    }
}
