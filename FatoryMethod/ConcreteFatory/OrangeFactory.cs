using FatoryMethod.ConcreteProduct;

namespace FatoryMethod.ConcreteFatory
{
    class OrangeFactory : FruitFatory
    {
        public Fruit GetFruit()
        {
            return new Orange();
        }
    }
}
