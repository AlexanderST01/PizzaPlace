using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor provee un nombre")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Por favor provee una calle")]
        public string? Calle { get; set; }
        [Required(ErrorMessage = "Por favor provee una ciudad")]
        public string? Ciudad { get; set; }

    }
}
