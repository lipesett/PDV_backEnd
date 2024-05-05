using PDV_backEnd.Models;

namespace PDV_backEnd.Repositories.Interfaces
{
    public interface IStatusRepositorio
    {
        Task<List<StatusModel>> BuscarTodos();
        Task<StatusModel> BuscarPorId(int id);
        Task<StatusModel> Adicionar(StatusModel status);
        Task<StatusModel> Atualizar(StatusModel status, int id);
        Task<bool> Apagar(int id);
    }
}