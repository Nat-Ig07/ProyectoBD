using Microsoft.EntityFrameworkCore; //Se llama a la librería de EntityFrameworkCore para conectarse a la base de datos
namespace ProyectoBD.Data
{
    public class RegistroDbContext : DbContext //Clase
    {
        public RegistroDbContext(DbContextOptions<RegistroDbContext> options) : base(options) //Constructor: Recibe los parámetros de conexión en el parámetro "options"
        {
        }

        public DbSet<Cliente> Clientes { get; set; } //Propiedad que se encarga de mapear la tabla de la base de datos con la clase Persona
    
        public DbSet<Servicio> Servicios { get; set; } //Propiedad que se encarga de mapear la tabla de la base de datos con la clase Servicio

        public DbSet<Mascota> Mascotas { get; set; } //Propiedad que se encarga de mapear la tabla de la base de datos con la clase Mascota
    }
}
