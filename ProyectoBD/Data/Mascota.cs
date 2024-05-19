using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProyectoBD.Data
{
    public class Mascota
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(30, ErrorMessage = "Nombre no puede contener más de 30 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string? Especie { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string? Raza { get; set; }

        // Clave foránea hacia Cliente
        public int ClienteId { get; set; }
        virtual public Cliente? Cliente { get; set; }

        // Clave foránea hacia Servicio
        virtual public ICollection<Servicio>? Servicios { get; set; }
    }
}
