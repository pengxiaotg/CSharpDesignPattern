using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    class LightButton : Button
    {
        public void Display()
        {
            Console.WriteLine("Show light button");
        }
    }
}
