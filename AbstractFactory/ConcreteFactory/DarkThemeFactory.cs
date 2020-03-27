using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactory
{
    class DarkThemeFactory : ThemeFactory
    {

        public Button CreateButton()
        {
            return new DarkButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new DarkCheckBox();
        }

        public TextField CreateTextField()
        {
            return new DarkTextField();
        }
    }
}
