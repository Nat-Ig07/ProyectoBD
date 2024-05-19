namespace ProyectoBD.Data
{
    public interface IRepositorio_Servicio
    {
        Task<List<Servicio>> GetAll();
        Task<Servicio> Get(int id);
        Task<Servicio> Add(Servicio servicio);
        Task<Servicio> Update(int id, Servicio servicio);
        Task Delete(int id);
    }
}
