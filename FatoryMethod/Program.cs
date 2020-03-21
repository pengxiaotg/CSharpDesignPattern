using System;
using FatoryMethod.ConcreteFatory;

namespace FatoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitFatory fruitFatory = new AppleFactory();
            Fruit fruit = fruitFatory.GetFruit();
            fruit.MethodSame();
            fruit.MethodDiff();
        }
    }
}
