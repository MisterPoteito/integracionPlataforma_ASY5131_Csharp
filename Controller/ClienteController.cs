using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private static IList<Cliente> _clientes = new List<Cliente>()
    {};
        // GET: api/clientes
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _clienteService.Clientes;
        }

        // GET: api/clientes/{Rut}
        [HttpGet("{Rut}")]
        public ActionResult<Cliente> Get(int Rut)
        {
            var cliente = _clienteService.BuscarCliente(Rut);
            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }

        // POST: api/clientes
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            if (_clienteService.Clientes.Any(c => c.Rut == cliente.Rut))
            {
                return BadRequest("Ya existe un cliente con el mismo RUT.");
            }

            _clienteService.AgregarCliente(cliente);
            return CreatedAtAction(nameof(Get), new { Rut = cliente.Rut }, cliente);
        }

        // PUT: api/clientes/{Rut}
        [HttpPut("{Rut}")]
        public IActionResult Put(int Rut, [FromBody] Cliente cliente)
        {
            var success = _clienteService.ActualizarCliente(Rut, cliente);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }

        // DELETE: api/clientes/{Rut}
        [HttpDelete("{Rut}")]
        public IActionResult Delete(int Rut)
        {
            var success = _clienteService.EliminarCliente(Rut);
            if (!success)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}