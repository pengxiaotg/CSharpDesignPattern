using System;
using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    class DarkCheckBox : CheckBox
    {
        public void Display()
        {
            Console.WriteLine("Show dark checkbox");
        }
    }
}
