namespace ProyectoBD.Data
{
    public interface IRepositorio_Mascota
    {
        Task<List<Mascota>> GetAll();
        Task<Mascota> Get(int id);
        Task <List<Servicio>> GetServicios(); //Método para obtener los servicios de una mascota
        Task<Mascota> Add(Mascota mascota);
        Task<Mascota> Update(int id, Mascota mascota);
        Task Delete(int id);
    }
}
 