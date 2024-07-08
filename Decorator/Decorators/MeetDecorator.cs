using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component;

namespace Decorator.Decorators
{
    public class MeetDecorator : Decorator
    {
        public int Price { get; init; }

        public MeetDecorator(IComponent _component, int prise = 150)
            : base(_component)
        {
            Price = prise;
            base.addTopping(Price);
        }

        public override void show()
        {
            base.show();
            Console.WriteLine($"MeetDecorator({Price})");
        }
    }
}
