using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracadoController : ControllerBase
    {
        private readonly ITracadoRepositorio _tracadoRepositorio;

        public TracadoController(ITracadoRepositorio tracadoRepositorio )
        {
            _tracadoRepositorio = tracadoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<TracadoModel>>> BuscarTodos()
        {
            List<TracadoModel> tracados = await _tracadoRepositorio.BuscarTodos();
            return Ok(tracados);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TracadoModel>> BuscarPorId(int id)
        {
            TracadoModel tracados = await _tracadoRepositorio.BuscarPorId(id);
            return Ok(tracados);
        }

        [HttpPost]
        public async Task<ActionResult<TracadoModel>> Adicionar([FromBody] TracadoModel model)
        {
            TracadoModel tracadosModel = await _tracadoRepositorio.Adicionar(model);
            return Ok(tracadosModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TracadoModel>> Atualizar([FromBody] TracadoModel model, int id)
        {
            model.TRA_ID = id;
            TracadoModel tracadosModel = await _tracadoRepositorio.Atualizar(model, id);
            return Ok(tracadosModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TracadoModel>> Apagar(int id)
        {
            bool apagado = await _tracadoRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
