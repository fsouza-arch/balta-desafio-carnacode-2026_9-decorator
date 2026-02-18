namespace Decorator.Domain.Beverages.Decorators;
public class CaramelDecorator : BeverageDecorator
{
    public CaramelDecorator(Beverage beverage) : base(beverage) { }

    public override string GetDescription() => _beverage.GetDescription() + ", Caramelo";
    public override decimal GetCost() => _beverage.GetCost() + 0.80m;
}
