using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactory
{
    class LightThemeFactory : ThemeFactory
    {
        public Button CreateButton()
        {
            return new LightButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new LightCheckBox();
        }

        public TextField CreateTextField()
        {
            return new LightTextField();
        }
    }
}
