namespace Decorator_Pattern.Pizza
{
    public class ExtraChesse : BasePizza
    {
        private readonly BasePizza _basePizza;

        public ExtraChesse(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }

        public override int Cost()
        {
            return _basePizza.Cost() + 10;
        }
    }
}
