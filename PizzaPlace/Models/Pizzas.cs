namespace PizzaPlace.Models
{
    public class Pizzas
    {
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public Picante Picante { get; }
        public Pizzas(int id, string  nombre, decimal precio, Picante picante)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Picante = picante;
        }
    }
}
