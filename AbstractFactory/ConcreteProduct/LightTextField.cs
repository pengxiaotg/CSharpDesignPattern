using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    class LightTextField : TextField
    {
        public void Display()
        {
            Console.WriteLine("Show light textfiled");
        }
    }
}
