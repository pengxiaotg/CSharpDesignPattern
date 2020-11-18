namespace Singleton
{
    public class LazySingleton
    {
        private static LazySingleton instance = null;
        private static readonly object syncRoot = new object();
        private LazySingleton() { }
        public static LazySingleton GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }
            return instance;
        }
    }
}