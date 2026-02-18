using Decorator.Domain.Beverages.Bases;
using Decorator.Domain.Beverages;
using Decorator.Domain.Beverages.Decorators;

Console.WriteLine("=== Sistema de Cafeteria (Padrão Decorator) ===\n");

// Exemplo 1: Espresso Simples
Beverage b1 = new Espresso();
Console.WriteLine($"{b1.GetDescription()} -> R$ {b1.GetCost():N2}");

// Exemplo 2: Espresso com Leite e Chocolate
// "Envolvemos" o Espresso com Leite, e depois com Chocolate
Beverage b2 = new Espresso();
b2 = new MilkDecorator(b2);
b2 = new ChocolateDecorator(b2);
Console.WriteLine($"{b2.GetDescription()} -> R$ {b2.GetCost():N2}");

// Exemplo 3: Cappuccino "Completo" (Leite, Chocolate, Chantilly, Caramelo)
// Podemos fazer tudo em uma linha (composição dinâmica)
Beverage b3 = new CaramelDecorator(new WhippedCreamDecorator(new ChocolateDecorator(new MilkDecorator(new Cappuccino()))));
Console.WriteLine($"{b3.GetDescription()} -> R$ {b3.GetCost():N2}");