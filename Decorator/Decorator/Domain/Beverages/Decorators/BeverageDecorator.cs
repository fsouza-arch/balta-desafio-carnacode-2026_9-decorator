namespace Decorator.Domain.Beverages.Decorators;

public abstract class BeverageDecorator : Beverage
{
    protected Beverage _beverage;

    protected BeverageDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }
}
