using System.ComponentModel.DataAnnotations;

namespace ActividadesWEB.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "No puedes poner mas de 50 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [MaxLength(50, ErrorMessage = "No puedes poner mas de 50 caracteres")]
        [EmailAddress(ErrorMessage = "El correo debe ser valido")]
        public string? Correo { get; set; }

        [Range(0, 10, ErrorMessage = "Calificacion no valida (0 - 10)")]
        [Required(ErrorMessage = "La calificacion es obligatoria")]
        public float? Calificacion { get; set; }
    }
}
