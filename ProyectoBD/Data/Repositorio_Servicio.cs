using Microsoft.EntityFrameworkCore;

namespace ProyectoBD.Data
{
    public class Repositorio_Servicio : IRepositorio_Servicio
    {
        private RegistroDbContext _context;

        //Constructor
        public Repositorio_Servicio(RegistroDbContext context)
        {
            _context = context;
        }

        //Metodos
        public async Task<Servicio> Add(Servicio servicio)
        {
            await _context.Servicios.AddAsync(servicio);
            await _context.SaveChangesAsync();
            return servicio;
        }

        public async Task Delete(int id)
        {
            Servicio servicio = await _context.Servicios.FindAsync(id);
            if (servicio != null)
            {
                _context.Servicios.Remove(servicio);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Servicio> Get(int id)
        {
            return await _context.Servicios.FindAsync(id);

        }

        public async Task<List<Servicio>> GetAll()
        {
            return await _context.Servicios.ToListAsync(); //Devuelve una lista de personas de la base de datos
        }

        public Task<Servicio> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Servicio> Update(int id, Servicio servicio)
        {
            Servicio servicioLocal = await _context.Servicios.FindAsync(id);
            if (servicioLocal != null)
            {
                servicioLocal.Producto = servicio.Producto;
                await _context.SaveChangesAsync();
            }
            return servicioLocal;
        }
    }
}
