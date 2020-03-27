using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    class LightCheckBox : CheckBox
    {
        public void Display()
        {
            Console.WriteLine("Show light checkbox");
        }
    }
}
