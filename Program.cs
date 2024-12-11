using System;

class Program
{
    static void Main(string[] args)
    {
        // Base component
        IComponent<string> baseComponent = new ConcreteComponent();

        // Plain Decorator
        IComponent<string> plainDecorator = new PlainDecorator(baseComponent);

        // Upper Case Decorator
        IComponent<string> upperCaseDecorator = new UpperCaseDecorator(plainDecorator);

        // Color Decorator
        IComponent<string> colorDecorator = new ColorDecorator(upperCaseDecorator);

        // Printing results
        Console.WriteLine("Base Component: " + baseComponent.GetText());
        Console.WriteLine("Plain Decorator: " + plainDecorator.GetText());
        Console.WriteLine("UpperCase Decorator: " + upperCaseDecorator.GetText());
        Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
    }
}
