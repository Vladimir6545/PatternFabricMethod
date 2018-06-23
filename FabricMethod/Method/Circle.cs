using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Method
{
    class Circle : IProduct
    {
        int _centerX = 10, _centerY = 5, _radius = 5;
        int _flag;
        public void DrawForm()
        {
            Random rand = new Random();
            _flag = rand.Next(10, 30);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Action<int, int> write = (xp, yp) => { Console.SetCursorPosition(xp, yp); Console.Write("*"); };

            _centerX = _centerX + _flag;
            _centerY = _centerY + (_flag/2);
            _radius = _radius + (_flag/2);
            int x = -_radius;
            while (x <= _radius)
            {
                var y = (int)Math.Floor(Math.Sqrt(_radius * _radius - x * x));

                write(x + _centerX, y + _centerY);
                y = -y;
                write(x + _centerX, y + _centerY);
                x++;
            }
            Console.SetCursorPosition(0,13);
        }
    }
}
