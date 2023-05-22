// See https://aka.ms/new-console-template for more information
using design_pattern_structural_decorator;

Console.WriteLine("Hello, World!");

IComponent component = new ConcreteComponent();

component = new ConcreteDecoratorA(component);
component = new ConcreteDecoratorB(component);

component.Operation();
