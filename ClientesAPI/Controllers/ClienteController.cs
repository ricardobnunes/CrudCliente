using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientesAPI.Models;

namespace ClienteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteContext _context;

        public ClienteController(ClienteContext context)
        {
            _context = context;

            if (_context.ClienteItems.Count() == 0)
            {
                // Create a new ClienteItem if collection is empty,
                // which means you can't delete all ClienteItems.
                _context.ClienteItems.Add(new ClienteItem { Name = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET: api/Cliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteItem>>> GetClienteItems()
        {
            return await _context.ClienteItems.ToListAsync();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteItem>> GetClienteItem(long id)
        {
            var ClienteItem = await _context.ClienteItems.FindAsync(id);

            if (ClienteItem == null)
            {
                return NotFound();
            }

            return ClienteItem;
        }

        [HttpPost]
        public async Task<ActionResult<ClienteItem>> PostClienteItem(ClienteItem item)
        {
            _context.ClienteItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClienteItem), new { id = item.Id }, item);
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClienteItem(long id, ClienteItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClienteItem(long id)
        {
            var ClienteItems = await _context.ClienteItems.FindAsync(id);

            if (ClienteItems == null)
            {
                return NotFound();
            }

            _context.ClienteItems.Remove(ClienteItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }


}