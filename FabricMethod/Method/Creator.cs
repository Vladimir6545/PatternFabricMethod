using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Method
{
    class Creator
    {
        byte _temp;
        public Creator()
        {
           // _temp = pp;
        }
        public void Temp(byte pp)
        {
            _temp = pp;
        }
        public IProduct CreateProduct()
        {
            if (_temp==1)
            {
                return new Circle();
            }
            else if (_temp == 2)
            {
                return new Square();
            }
            else if (_temp == 3)
            {
                return new Lines();
            }
            else return null;
        }
    }
}
