namespace Decorator.Domain.Beverages.Decorators;

public class WhippedCreamDecorator : BeverageDecorator
{
    public WhippedCreamDecorator(Beverage beverage) : base(beverage) { }

    public override string GetDescription() => _beverage.GetDescription() + ", Chantilly";
    public override decimal GetCost() => _beverage.GetCost() + 1.00m;
}
