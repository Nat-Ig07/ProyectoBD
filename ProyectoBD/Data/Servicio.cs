using System.ComponentModel.DataAnnotations;

namespace ProyectoBD.Data
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string? Producto { get; set; }

        // Clave foránea hacia Mascota
        public int MascotaId { get; set; }
        virtual public Mascota? Mascota { get; set; }

    }
}
