using System;
using Builder.ConcreteBuilder;

namespace Builder
{
    // 客户端调用
    class Program
    {
        static void Main(string[] args)
        {
            OnePlus onePlus = new OnePlus();
            onePlus.SetPhoneBuilder(new OnePlus7TBuilder());
            //onePlus.SetPhoneBuilder(new OnePlus6TBuilder());
            Phone phone = onePlus.Construct();
            Console.WriteLine(phone.Name);
            Console.WriteLine(phone.SOC);
            Console.WriteLine(phone.Screen);
            Console.WriteLine(phone.Camera);
            Console.WriteLine(phone.Battery);
        }
    }
}
