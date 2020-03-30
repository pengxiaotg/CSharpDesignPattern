namespace Builder
{
    //Builder
    abstract class PhoneBuilder
    {
        // 创建产品对象
        protected Phone phone = new Phone();
        public abstract void BuildName();
        public abstract void BuildSOC();
        public abstract void BuildScreen();
        public abstract void BuildCamera();
        public abstract void BuildBattery();

        // 获取产品对象 GetResult
        public Phone GetPhone()
        {
            return phone;
        }
    }
}
