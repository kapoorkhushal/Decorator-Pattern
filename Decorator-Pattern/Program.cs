using Decorator_Pattern.Pizza;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Margharetta Pizza Price: {new MargharettaPizza().Cost()}");
            Console.WriteLine($"Margharetta Pizza With Extra Toppings Price: {new ExtraToppings(new MargharettaPizza()).Cost()}");
            Console.WriteLine($"Margharetta Pizza With Extra Chesse Price: {new ExtraChesse(new MargharettaPizza()).Cost()}");
            Console.WriteLine($"Farmhouse Pizza Price: {new FarmHousePizza().Cost()}");
            Console.WriteLine($"Farmhouse Pizza With Extra Toppings Price: {new ExtraToppings(new FarmHousePizza()).Cost()}");
            Console.WriteLine($"Farmhouse Pizza With Extra Chesse Price: {new ExtraChesse(new FarmHousePizza()).Cost()}");

            Console.WriteLine($"Margharetta Pizza With Extra Chesse With Extra Toppings Price: {new ExtraToppings(new ExtraChesse(new MargharettaPizza())).Cost()}");

            Console.ReadLine();
        }
    }
}