using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProyectoBD.Data
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(30, ErrorMessage = "Nombre no puede contener más de 30 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(30, ErrorMessage = "Dirección no puede contener más de 30 caracteres")]
        public string? Direccion { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Length(10, 10, ErrorMessage = "Teléfono debe contener 10 digitos")]
        public string? Telefono { get; set; }

        //Navegación: Cliente a mascotas (uno a muchos)
        virtual public ICollection<Mascota>? Mascotas { get; set; }
    }
}