namespace Singleton
{
    public class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();

        private EagerSingleton() { }

        public static EagerSingleton GetInstance()
        {
            return instance;
        }
    }
}