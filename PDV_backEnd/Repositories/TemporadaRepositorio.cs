using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Data;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Repositories
{
    public class TemporadaRepositorio : ITemporadaRepositorio
    {
        private readonly PDVDbContext _dbContext;

        public TemporadaRepositorio(PDVDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TemporadaModel>> BuscarTodos()
        {
            return await _dbContext.Temporadas.ToListAsync();
        }

        public async Task<TemporadaModel> BuscarPorId(int id)
        {
            return await _dbContext.Temporadas.FirstOrDefaultAsync(x => x.TEM_ID == id);
        }

        public async Task<TemporadaModel> Adicionar(TemporadaModel temporada)
        {
            await _dbContext.Temporadas.AddAsync(temporada);
            await _dbContext.SaveChangesAsync();

            return temporada;
        }

        public async Task<TemporadaModel> Atualizar(TemporadaModel temporada, int id)
        {
            TemporadaModel temporadaPorId = await BuscarPorId(id);

            if (temporadaPorId == null)
            {
                throw new Exception($"Temporada para o ID: {id} não encontrado.");
            }

            temporadaPorId.TEM_NUMTEM = temporada.TEM_NUMTEM;
            temporadaPorId.TEM_NOME = temporada.TEM_NOME;
            temporadaPorId.TEM_ETAPAS = temporada.TEM_ETAPAS;
            temporadaPorId.TEM_INICIO = temporada.TEM_INICIO;
            temporadaPorId.TEM_FINAL = temporada.TEM_FINAL;
            temporadaPorId.TEM_ANO = temporada.TEM_ANO;

            _dbContext.Temporadas.Update(temporadaPorId);
            await _dbContext.SaveChangesAsync();

            return temporadaPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            TemporadaModel temporadaPorId = await BuscarPorId(id);

            if (temporadaPorId == null)
            {
                throw new Exception($"Temporada para o ID: {id} não encontrado.");
            }

            _dbContext.Temporadas.Remove(temporadaPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
