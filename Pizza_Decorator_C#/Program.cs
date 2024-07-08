


Pizza pizza = new Pizza(PizzaTipe.ChicagoPizza, 100);
IComponent component = pizza;
component = new CheeseDecorator(component);
component = new MeetDecorator(component);


component.show();
Console.WriteLine($"Pizza price: {pizza.Price}");
