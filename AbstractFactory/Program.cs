using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ThemeFactory themeFactory = new LightThemeFactory();
            Button button = themeFactory.CreateButton();
            TextField textField = themeFactory.CreateTextField();
            CheckBox checkBox = themeFactory.CreateCheckBox();
            button.Display();
            textField.Display();
            checkBox.Display();
        }
    }
}
