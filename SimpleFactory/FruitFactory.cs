using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class FruitFactory
    {
        public static Fruit GetFruit(string arg)
        {
            Fruit fruit = null;
            if (arg == "Apple")
            {
                fruit = new Apple();
            } 
            else if (arg == "Orange")
            {
                fruit = new Orange();
            }
            return fruit;
        }
    }
}
