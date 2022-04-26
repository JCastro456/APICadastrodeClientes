using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using womanAPI.Models;

namespace womanAPI.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class ClientesController : ControllerBase {
        private readonly Contexto _contexto;

        public ClientesController (Contexto contexto) {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> PegarTodosAsync () {
            return await _contexto.Clientes.ToListAsync();
        }

        [HttpGet ("{Id}")]
        public async Task<ActionResult<Clientes>> PegarPessoaPeloIdAsync (int Id) {
            Clientes clientes = await _contexto.Clientes.FindAsync (Id);

            if (clientes == null)
                return NotFound ();

            return clientes;
        }

        [HttpPost]
        public async Task<ActionResult<Clientes>> SalvarClientesAsync (Clientes clientes) {
            await _contexto.Clientes.AddAsync (clientes);
            await _contexto.SaveChangesAsync();

            return Ok ();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarClientesAsync (Clientes clientes) {
            _contexto.Clientes.Update (clientes);
            await _contexto.SaveChangesAsync();

            return Ok ();
        }

        [HttpDelete ("{Id}")]
        public async Task<ActionResult> ExcluirClientesAsync (int Id) {
            Clientes clientes = await _contexto.Clientes.FindAsync (Id);
            if (clientes == null)
                return NotFound ();

            _contexto.Remove (clientes);
            await _contexto.SaveChangesAsync();
            return Ok ();
        }

    }
}  
    
