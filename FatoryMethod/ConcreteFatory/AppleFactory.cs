using FatoryMethod.ConcreteProduct;

namespace FatoryMethod.ConcreteFatory
{
    class AppleFactory : FruitFatory
    {
        public Fruit GetFruit()
        {
            return new Apple();
        }
    }
}
