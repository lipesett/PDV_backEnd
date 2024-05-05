using PDV_backEnd.Models;

namespace PDV_backEnd.Repositories.Interfaces
{
    public interface ITracadoRepositorio
    {
        Task<List<TracadoModel>> BuscarTodos();
        Task<TracadoModel> BuscarPorId(int id);
        Task<TracadoModel> Adicionar(TracadoModel status);
        Task<TracadoModel> Atualizar(TracadoModel status, int id);
        Task<bool> Apagar(int id);
    }
}