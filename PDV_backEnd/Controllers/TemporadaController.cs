using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemporadaController : ControllerBase
    {
        private readonly ITemporadaRepositorio _temporadaRepositorio;

        public TemporadaController(ITemporadaRepositorio temporadaRepositorio)
        {
            _temporadaRepositorio = temporadaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<TemporadaModel>>> BuscarTodos()
        {
            List<TemporadaModel> temporada = await _temporadaRepositorio.BuscarTodos();
            return Ok(temporada);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TemporadaModel>> BuscarPorId(int id)
        {
            TemporadaModel temporada = await _temporadaRepositorio.BuscarPorId(id);
            return Ok(temporada);
        }

        [HttpPost]
        public async Task<ActionResult<TemporadaModel>> Adicionar([FromBody] TemporadaModel model)
        {
            TemporadaModel temporadaModel = await _temporadaRepositorio.Adicionar(model);
            return Ok(temporadaModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TemporadaModel>> Atualizar([FromBody] TemporadaModel model, int id)
        {
            model.TEM_ID = id;
            TemporadaModel temporadaModel = await _temporadaRepositorio.Atualizar(model, id);
            return Ok(temporadaModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TemporadaModel>> Apagar(int id)
        {
            bool apagado = await _temporadaRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
