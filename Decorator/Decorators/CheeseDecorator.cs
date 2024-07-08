using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component;

namespace Decorator.Decorators
{
    public class CheeseDecorator : Decorator
    {
        public int Price { get; init; }

        public CheeseDecorator(IComponent _component, int prise = 100)
            : base(_component)
        {
            Price = prise;
            base.addTopping(Price);
        }

        public override void show()
        {
            base.show();
            Console.WriteLine($"CheeseDecorator({Price})");
        }
    }
}
