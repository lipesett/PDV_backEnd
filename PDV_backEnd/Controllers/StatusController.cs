using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDV_backEnd.Models;
using PDV_backEnd.Repositories;
using PDV_backEnd.Repositories.Interfaces;

namespace PDV_backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusRepositorio _statusRepositorio;

        public StatusController(IStatusRepositorio statusRepositorio )
        {
            _statusRepositorio = statusRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<StatusModel>>> BuscarTodos()
        {
            List<StatusModel> status = await _statusRepositorio.BuscarTodos();
            return Ok(status);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StatusModel>> BuscarPorId(int id)
        {
            StatusModel status = await _statusRepositorio.BuscarPorId(id);
            return Ok(status);
        }

        [HttpPost]
        public async Task<ActionResult<StatusModel>> Adicionar([FromBody] StatusModel model)
        {
            StatusModel statusModel = await _statusRepositorio.Adicionar(model);
            return Ok(statusModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<StatusModel>> Atualizar([FromBody] StatusModel model, int id)
        {
            model.STA_ID = id;
            StatusModel statusModel = await _statusRepositorio.Atualizar(model, id);
            return Ok(statusModel);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<StatusModel>> Apagar(int id)
        {
            bool apagado = await _statusRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
