using System.Diagnostics.Metrics;
using ContosoPizza.Models;

namespace ContosoPizza.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PizzaContext context)
        {

            if (context.Pizzas.Any())
            {
                return;   // DB has been seeded
            }

            var pizzas = new Pizza[]
            {
                new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
                new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
            };

            context.Pizzas.AddRange(pizzas);
            context.SaveChanges();
        }
    }
}