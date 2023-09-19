namespace PizzaPlace.Models
{
    public class CanastaCompras
    {
        public Clientes Clientes { get; set; } = new();
        public List<int> Ordenes { get; set; } = new();
        public bool HaPagodo { get; set; }
        public void Agregar(int pizzaId) => Ordenes.Add(pizzaId);
        public void Remover(int pos) => Ordenes.RemoveAt(pos);
    }
}
