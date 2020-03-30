namespace Builder.ConcreteBuilder
{
    class OnePlus6TBuilder : PhoneBuilder
    {
        public override void BuildName()
        {
            this.phone.Name = "OnePlus 6T";
        }
        public override void BuildSOC()
        {
            this.phone.SOC = "Qualcomm Snapdragon 845";
        }
        public override void BuildScreen()
        {
            this.phone.Screen = "6.41-inch 19.5:9 Optic AMOLED";
        }
        public override void BuildCamera()
        {
            this.phone.Camera = "Sony IMX 519";
        }
        public override void BuildBattery()
        {
            this.phone.Battery = "3700 mAh lithium battery";
        }
    }
}
