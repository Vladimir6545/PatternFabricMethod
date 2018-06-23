using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Method
{
    class Lines : IProduct
    {
        int _startposx = 11;
        int _startposy = 11;
        int _flag;
        public void DrawForm()
        {
            Random rand = new Random();
            _flag = rand.Next(10, 30);
            _startposx = _startposx + _flag;
            _startposy = _startposy + _flag;
            Console.ForegroundColor = ConsoleColor.Red;
            for (int x = 0; x < 10; x++)
            {
                int y = (x + 2) * -1;//считаем уравнение
                Console.SetCursorPosition(_startposx + x, _startposy + y);
                Console.Write("*");
            }

        }
    }
}
