namespace Builder.ConcreteBuilder
{
    class OnePlus7TBuilder : PhoneBuilder
    {
        public override void BuildName()
        {
            this.phone.Name = "OnePlus 7T";
        }
        public override void BuildSOC()
        {
            this.phone.SOC = "Qualcomm Snapdragon 855 Plus";
        }
        public override void BuildScreen()
        {
            this.phone.Screen = "Samsung 6.55-inch 90Hz Fluid Display";
        }
        public override void BuildCamera()
        {
            this.phone.Camera = "Sony IMX 586";
        }
        public override void BuildBattery()
        {
            this.phone.Battery = "3800 mAh lithium battery";
        }
    }
}
