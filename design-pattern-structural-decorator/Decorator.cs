using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern_structural_decorator
{
    public abstract class Decorator : IComponent
    {
        private readonly IComponent _component;

        public Decorator(IComponent component)
        {
            this._component = component;
        }
        public virtual void Operation()
        {
            this._component.Operation();
        }
    }
}
