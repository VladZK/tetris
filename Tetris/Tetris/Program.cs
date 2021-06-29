using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 3;
            int y1 = 5;
            char sym = '#';

            Drow(x1, y1, sym);
           
        }

        static void Drow(int x, int y, char sym)
        {

            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);


        }

    }
}
