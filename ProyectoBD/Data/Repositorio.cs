using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace ProyectoBD.Data
{
    public class Repositorio : IRepositorio
    {
        private RegistroDbContext _context;

        //Constructor
        public Repositorio(RegistroDbContext context)
        {
            _context = context;
        }

        //Metodos
        public async Task<Cliente> Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task Delete(int id)
        {
            Cliente cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente> Get(int id)
        {
            return await _context.Clientes.FindAsync(id);

        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync(); //Devuelve una lista de personas de la base de datos
        }

        public async Task<List<Mascota>> GetMascotas()
        {
            return await _context.Mascotas.ToListAsync(); //Devuelve una lista de personas de la base de datos
        }

        public Task<Cliente> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Cliente> Update(int id, Cliente cliente)
        {
            Cliente clienteLocal = await _context.Clientes.FindAsync(id);
            if (clienteLocal != null)
            {
                clienteLocal.Nombre = cliente.Nombre;
                clienteLocal.Direccion = cliente.Direccion;
                clienteLocal.Telefono = cliente.Telefono;
                await _context.SaveChangesAsync();
            }
            return clienteLocal;
        }
    }
}

