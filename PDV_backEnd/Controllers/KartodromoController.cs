using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KartodromoController : ControllerBase
    {
        private readonly IKartodromoRepositorio _kartodromoRepositorio;

        public KartodromoController(IKartodromoRepositorio kartodromoRepositorio)
        {
            _kartodromoRepositorio = kartodromoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<KartodromoModel>>> BuscarTodos() {
            List<KartodromoModel> kartodromos = await _kartodromoRepositorio.BuscarTodos();
            return Ok(kartodromos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<KartodromoModel>> BuscarPorId(int id)
        {
            KartodromoModel kartodromo = await _kartodromoRepositorio.BuscarPorId(id);
            return Ok(kartodromo);
        }

        [HttpPost]
        public async Task<ActionResult<KartodromoModel>> Adicionar([FromBody] KartodromoModel model)
        {
            KartodromoModel kartodromoModel = await _kartodromoRepositorio.Adicionar(model);
            return Ok(kartodromoModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<KartodromoModel>> Atualizar([FromBody] KartodromoModel model, int id)
        {
            model.KAR_ID = id;
            KartodromoModel kartodromoModel = await _kartodromoRepositorio.Atualizar(model, id);
            return Ok(kartodromoModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<KartodromoModel>> Apagar(int id)
        {
            bool apagado = await _kartodromoRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
