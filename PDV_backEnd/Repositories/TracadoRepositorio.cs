using Microsoft.EntityFrameworkCore;
using PDV_backEnd.Data;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Repositories
{
    public class TracadoRepositorio : ITracadoRepositorio
    {
        private readonly PDVDbContext _dbContext;

        public TracadoRepositorio(PDVDbContext pDVDbContext)
        {
            _dbContext = pDVDbContext;
        }

        public async Task<List<TracadoModel>> BuscarTodos()
        {
            return await _dbContext.Tracados.ToListAsync();
        }

        public async Task<TracadoModel> BuscarPorId(int id)
        {
            return await _dbContext.Tracados.FirstOrDefaultAsync(x => x.TRA_ID == id);
        }

        public async Task<TracadoModel> Adicionar(TracadoModel tracado)
        {
            await _dbContext.Tracados.AddAsync(tracado);
            await _dbContext.SaveChangesAsync();

            return tracado;
        }

        public async Task<TracadoModel> Atualizar(TracadoModel tracado, int id)
        {
            TracadoModel tracadoPorId = await BuscarPorId(id);

            if (tracadoPorId == null)
            {
                throw new Exception($"Traçado para o ID: {id} não encontrado.");
            }

            tracadoPorId.TRA_NOME = tracado.TRA_NOME;
            tracadoPorId.TRA_DATA_ESTREIA = tracado.TRA_DATA_ESTREIA;
            tracadoPorId.PIL_VENCEDOR = tracado.PIL_VENCEDOR;
            tracadoPorId.EQI_VENCEDORA = tracado.EQI_VENCEDORA;
            tracadoPorId.CLI_CLIMA = tracado.CLI_CLIMA;
            tracadoPorId.SEN_SENTIDO = tracado.SEN_SENTIDO;
            tracadoPorId.KAR_KARTODROMO = tracado.KAR_KARTODROMO;
            tracadoPorId.CAL_NUMERO_ETAPA = tracado.CAL_NUMERO_ETAPA;
            tracadoPorId.MV_ESTREIA = tracado.MV_ESTREIA;
            tracadoPorId.MV_RECORD = tracado.MV_RECORD;

            _dbContext.Tracados.Update(tracadoPorId);
            await _dbContext.SaveChangesAsync();

            return tracadoPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            TracadoModel tracadoPorId = await BuscarPorId(id);

            if (tracadoPorId == null)
            {
                throw new Exception($"Traçado para o ID: {id} não encontrado.");
            }

            _dbContext.Tracados.Remove(tracadoPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }        
    }
}
