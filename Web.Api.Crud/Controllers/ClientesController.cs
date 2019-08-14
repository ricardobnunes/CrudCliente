using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Api.Crud.Models;

namespace Web.Api.Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteContext _context;

        public ClientesController(ClienteContext context)
        {
            _context = context;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clientes>>> GetCliente()
        {
            return await _context.Cliente.ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clientes>> GetClientes(int id)
        {
            var clientes = await _context.Cliente.FindAsync(id);

            if (clientes == null)
            {
                return NotFound();
            }

            return clientes;
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientes(int id, Clientes clientes)
        {
            if (id != clientes.ClienteId)
            {
                return BadRequest();
            }

            _context.Entry(clientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Clientes
        [HttpPost]
        public async Task<ActionResult<Clientes>> PostClientes(Clientes clientes)
        {
            _context.Cliente.Add(clientes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientes", new { id = clientes.ClienteId }, clientes);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Clientes>> DeleteClientes(int id)
        {
            var clientes = await _context.Cliente.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }

            _context.Cliente.Remove(clientes);
            await _context.SaveChangesAsync();

            return clientes;
        }

        private bool ClientesExists(int id)
        {
            return _context.Cliente.Any(e => e.ClienteId == id);
        }
    }
}
