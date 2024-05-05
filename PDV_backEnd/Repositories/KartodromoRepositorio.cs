using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Data;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Repositories
{
    public class KartodromoRepositorio : IKartodromoRepositorio
    {
        private readonly PDVDbContext _dbContext;

        public KartodromoRepositorio(PDVDbContext pDVDbContext)
        {
            _dbContext = pDVDbContext;
        }

        public async Task<List<KartodromoModel>> BuscarTodos()
        {
            return await _dbContext.Kartodromos.ToListAsync();
        }

        public async Task<KartodromoModel> BuscarPorId(int id)
        {
            return await _dbContext.Kartodromos.FirstOrDefaultAsync(x => x.KAR_ID == id);
        }

        public async Task<KartodromoModel> Adicionar(KartodromoModel kartodromo)
        {
            await _dbContext.Kartodromos.AddAsync(kartodromo);
            await _dbContext.SaveChangesAsync();

            return kartodromo;
        }

        public async Task<KartodromoModel> Atualizar(KartodromoModel kartodromo, int id)
        {
            KartodromoModel kartodromoPorId = await BuscarPorId(id);

            if (kartodromoPorId == null)
            {
                throw new Exception($"Kartódromo para o ID: {id} não encontrado.");
            }

            kartodromoPorId.KAR_NOME = kartodromo.KAR_NOME;
            kartodromoPorId.KAR_NOMECURTO = kartodromo.KAR_NOMECURTO;
            kartodromoPorId.KAR_APELIDO = kartodromo.KAR_APELIDO;
            kartodromoPorId.CID_KARTODROMO = kartodromo.CID_KARTODROMO;

            _dbContext.Kartodromos.Update(kartodromoPorId);
            await _dbContext.SaveChangesAsync();

            return kartodromoPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            KartodromoModel kartodromoPorId = await BuscarPorId(id);

            if (kartodromoPorId == null)
            {
                throw new Exception($"Kartódromo para o ID: {id} não encontrado.");
            }

            _dbContext.Kartodromos.Remove(kartodromoPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }        
    }
}
