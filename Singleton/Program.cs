using System;

namespace Singleton
{
    class Program
    {
        static void VerifySingleton()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            if(s1 == s2)
            {
                Console.WriteLine("s1 == s2");
            }
        }

        static void VerifyLazySingleton()
        {
            LazySingleton s3 = LazySingleton.GetInstance();
            LazySingleton s4 = LazySingleton.GetInstance();
            if(s3 == s4)
            {
                Console.WriteLine("s3 == s4");
            }
        }

        static void VerifyEagerSingleton()
        {
            EagerSingleton s5 = EagerSingleton.GetInstance();
            EagerSingleton s6 = EagerSingleton.GetInstance();
            if(s5 == s6)
            {
                Console.WriteLine("s5 == s6");
            }
        }

        static void Main(string[] args)
        {
            VerifySingleton();
            VerifyLazySingleton();
            VerifyEagerSingleton();
        }
    }
}
