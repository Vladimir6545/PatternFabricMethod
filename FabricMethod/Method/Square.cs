using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Method
{
    class Square : IProduct
    {
        int _lenght = 10, _width = 5;
        public void DrawForm()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //int lenght = 10, width = 5;
            for (int j = 0; j < _width; j++)
            {
                for (int i = 0; i < _lenght; i++)
                {
                    if (j == 0 || j == _width - 1) Console.Write("*");
                    else if (i == 0 || i == _lenght - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
