using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ActividadesWEB.Models
{
    public class Productos
    {
        [Range(1, 9999, ErrorMessage = "Debe ser entero positivo mayor a 0")]
        [Required(ErrorMessage = "Este campo es obligatorio y no puede estar vacio")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio y no puede estar vacio")]
        [MaxLength(200, ErrorMessage = "No puedes poner mas de 50 caracteres")]
        public string? Nombre { get; set; }
        public string? Departamento { get; set; }
    }
}
