using Component;

namespace Decorator
{
    public abstract class Decorator : IComponent
    {
        private IComponent component;

        public Decorator(IComponent _component)
        {
            component = _component;
        }

        public virtual void show() => component.show();
        public void addTopping(int price) => component.addTopping(price);
    }
}
