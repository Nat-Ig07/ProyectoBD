namespace ProyectoBD.Data
{
    public interface IRepositorio
    {
        Task<List<Cliente>> GetAll();
        Task<Cliente> Get(int id);

        Task<List<Mascota>> GetMascotas();

        Task<Cliente> Add(Cliente cliente);
        Task<Cliente> Update(int id, Cliente cliente);
        Task Delete(int id);
    }
}

