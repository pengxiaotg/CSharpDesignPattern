namespace Builder
{
    // Director
    class OnePlus
    {
        private PhoneBuilder phoneBuilder;

        public void SetPhoneBuilder(PhoneBuilder phoneBuilder)
        {
            this.phoneBuilder = phoneBuilder;
        }
        public Phone Construct()
        {
            phoneBuilder.BuildName();
            phoneBuilder.BuildSOC();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildCamera();
            phoneBuilder.BuildBattery();
            return phoneBuilder.GetPhone();
        }
    }
}
