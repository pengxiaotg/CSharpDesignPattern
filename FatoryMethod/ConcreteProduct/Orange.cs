using System;
using System.Collections.Generic;
using System.Text;

namespace FatoryMethod.ConcreteProduct
{
    class Orange : Fruit
    {
        public override void MethodDiff()
        {
            Console.WriteLine("Different method for Orange");
        }
    }
}
