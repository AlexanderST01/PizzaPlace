using PizzaPlace.BLL;
namespace PizzaPlace.Models
{
    public class Estados
    {
        public Menu Menu { get; set; } = new Menu();
        public CanastaCompras CanastaCompras { get; set; } = new CanastaCompras();
        public InterfasUsuario InterfasUsuario { get; set;} = new InterfasUsuario();
        public decimal PrecioTotal => CanastaCompras.Ordenes.Sum(id => Menu.OptenerPizzas(id)!.Precio);
    }
}
