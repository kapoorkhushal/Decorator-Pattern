namespace Decorator_Pattern.Pizza
{
    public class ExtraToppings: BasePizza
    {
        private readonly BasePizza _basePizza;

        public ExtraToppings(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }

        public override int Cost()
        {
            return _basePizza.Cost() + 50;
        }
    }
}
