using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    class DarkTextField : TextField
    {
        public void Display()
        {
            Console.WriteLine("Show dark textfield");
        }
    }
}
