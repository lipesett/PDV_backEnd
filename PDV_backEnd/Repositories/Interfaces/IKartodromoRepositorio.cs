using PDV_backEnd.Models;

namespace PDV_backEnd.Repositories.Interfaces
{
    public interface IKartodromoRepositorio
    {
        Task<List<KartodromoModel>> BuscarTodos();
        Task<KartodromoModel> BuscarPorId(int id);
        Task<KartodromoModel> Adicionar(KartodromoModel kartodromo);
        Task<KartodromoModel> Atualizar(KartodromoModel kartodromo, int id);
        Task<bool> Apagar(int id);
    }
}
