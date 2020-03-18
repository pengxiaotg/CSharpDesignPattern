using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class Apple : Fruit
    {
        public override void MethodDiff()
        {
            Console.WriteLine("Different method for Apple");
        }
    }
}
