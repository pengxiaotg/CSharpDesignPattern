using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    abstract class Fruit
    {
        // 所有产品类的公共业务方法
        public void MethodSame()
        {
            Console.WriteLine("Same method for all fruit");
        }
        // 声明抽象业务方法
        public abstract void MethodDiff();
    }
}
