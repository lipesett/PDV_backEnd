using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Data;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Repositories
{
    public class StatusRepositorio : IStatusRepositorio
    {
        private readonly PDVDbContext _dbContext;

        public StatusRepositorio(PDVDbContext pDVDbContext)
        {
            _dbContext = pDVDbContext;
        }

        public async Task<List<StatusModel>> BuscarTodos()
        {
            return await _dbContext.Status.ToListAsync();
        }

        public async Task<StatusModel> BuscarPorId(int id)
        {
            return await _dbContext.Status.FirstOrDefaultAsync(x => x.STA_ID == id);
        }

        public async Task<StatusModel> Adicionar(StatusModel status)
        {
            await _dbContext.Status.AddAsync(status);
            await _dbContext.SaveChangesAsync();

            return status;
        }

        public async Task<StatusModel> Atualizar(StatusModel status, int id)
        {
            StatusModel statusPorId = await BuscarPorId(id);

            if (statusPorId == null)
            {
                throw new Exception($"Status para o ID: {id} não encontrado.");
            }

            statusPorId.STA_ATIVO = status.STA_ATIVO;
            statusPorId.STA_DESC = status.STA_DESC;

            _dbContext.Status.Update(statusPorId);
            await _dbContext.SaveChangesAsync();

            return statusPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            StatusModel statusPorId = await BuscarPorId(id);

            if (statusPorId == null)
            {
                throw new Exception($"Status para o ID: {id} não encontrado.");
            }

            _dbContext.Status.Remove(statusPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }        
    }
}
