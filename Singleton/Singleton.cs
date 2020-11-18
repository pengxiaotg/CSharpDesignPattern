namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
            // 私有构造函数
        }

        public static Singleton GetInstance()
        {
            if(instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}