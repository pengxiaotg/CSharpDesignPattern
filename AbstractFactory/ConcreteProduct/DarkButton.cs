using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    class DarkButton : Button
    {
        public void Display()
        {
            Console.WriteLine("Show dark button");
        }
    }
}
