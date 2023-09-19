using System.Linq;
using PizzaPlace.Models;

namespace PizzaPlace.BLL
{
    public class Menu
    {
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Add(Pizzas pizzas) 
        => Pizzas.Add(pizzas);
        public Pizzas? OptenerPizzas(int id) 
        => Pizzas.SingleOrDefault(Pizzas => Pizzas.Id == id);
    }
}
