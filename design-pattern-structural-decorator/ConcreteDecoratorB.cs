using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_structural_decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("Feature added of Decorator B...");
        }

        public void AddedBehavior()
        {
            Console.WriteLine("Feature behavior added...");
        }
    }
}
