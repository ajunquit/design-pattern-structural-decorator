using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_structural_decorator
{
    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Operación del componente base");
        }
    }
}
