using Decorator.Domain.Beverages;

namespace Decorator.Domain.Beverages.Bases;

public class Espresso : Beverage
{
    public override string GetDescription() => "Espresso";
    public override decimal GetCost() => 3.50m;
}
