namespace Decorator.Domain.Beverages.Decorators;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(Beverage beverage) : base(beverage) { }

    public override string GetDescription() => _beverage.GetDescription() + ", Leite";
    public override decimal GetCost() => _beverage.GetCost() + 0.50m;
}
