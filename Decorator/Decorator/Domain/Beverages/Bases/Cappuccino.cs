using Decorator.Domain.Beverages;

namespace Decorator.Domain.Beverages.Bases;

public class Cappuccino : Beverage
{
    public override string GetDescription() => "Cappuccino";
    public override decimal GetCost() => 4.50m;
}
