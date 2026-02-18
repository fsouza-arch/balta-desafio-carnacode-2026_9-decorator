namespace Decorator.Domain.Beverages.Decorators;

public class ChocolateDecorator : BeverageDecorator
{
    public ChocolateDecorator(Beverage beverage) : base(beverage) { }

    public override string GetDescription() => _beverage.GetDescription() + ", Chocolate";
    public override decimal GetCost() => _beverage.GetCost() + 0.70m;
}
