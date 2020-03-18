using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit= FruitFactory.GetFruit("Apple");
            fruit.MethodSame();
            fruit.MethodDiff();
        }
    }
}
