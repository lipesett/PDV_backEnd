using PDV_backEnd.Models;

namespace PDV_backEnd.Repositories.Interfaces
{
    public interface ITemporadaRepositorio
    {
        Task<List<TemporadaModel>> BuscarTodos();
        Task<TemporadaModel> BuscarPorId(int id);
        Task<TemporadaModel> Adicionar(TemporadaModel status);
        Task<TemporadaModel> Atualizar(TemporadaModel status, int id);
        Task<bool> Apagar(int id);
    }
}
