using FabricMethod.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Настройка системы для рисования кругов, квадратов и линий. Создан фабричный метод,
который создает экземпляр одного из этих классов наугад и использует его, чтобы 
нарисовать форму случайного размера в консоле. */
namespace FabricMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Creator create = new Creator();
            for (int i = 0; i < 20; i++)
            {
                byte p = (byte)rand.Next(1, 4);
               // Console.WriteLine(p);
                create.Temp(p);
                IProduct product;
                product = create.CreateProduct();
                product.DrawForm();
            }
            Console.ReadLine();
        }
    }
}
