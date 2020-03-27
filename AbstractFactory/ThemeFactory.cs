using AbstractFactory.AbstractProduct;

namespace AbstractFactory
{
    interface ThemeFactory
    {
        public Button CreateButton();
        public TextField CreateTextField();
        public CheckBox CreateCheckBox();
    }
}
