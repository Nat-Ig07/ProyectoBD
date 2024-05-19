using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace ProyectoBD.Data
{
    public class Repositorio_Mascota : IRepositorio_Mascota

    {
        private RegistroDbContext _context;

        //Constructor
        public Repositorio_Mascota(RegistroDbContext context)
        {
            _context = context;
        }

        //Metodos
        public async Task<Mascota> Add(Mascota mascota)
        {
            await _context.Mascotas.AddAsync(mascota);
            await _context.SaveChangesAsync();
            return mascota;
        }

        public async Task Delete(int id)
        {
            Mascota mascota = await _context.Mascotas.FindAsync(id);
            if (mascota != null)
            {
                _context.Mascotas.Remove(mascota);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Mascota> Get(int id)
        {
            return await _context.Mascotas.FindAsync(id);

        }

        public async Task<List<Mascota>> GetAll()
        {
            return await _context.Mascotas.ToListAsync(); //Devuelve una lista de mascotas de la base de datos
        }

        // Método para obtener los servicios de una mascota
        public async Task<List<Servicio>> GetServicios()
        {
            return await _context.Servicios.ToListAsync(); //Devuelve una lista de servicios de la base de datos
        }

        public Task<Mascota> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Mascota> Update(int id, Mascota mascota)
        {
            Mascota mascotaLocal = await _context.Mascotas.FindAsync(id);
            if (mascotaLocal != null)
            {
                mascotaLocal.Nombre = mascota.Nombre;
                mascotaLocal.Especie = mascota.Especie;
                mascotaLocal.Raza = mascota.Raza;
                await _context.SaveChangesAsync();
            }
            return mascotaLocal;
        }
    }
}
