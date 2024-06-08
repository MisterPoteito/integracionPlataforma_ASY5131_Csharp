using Microsoft.AspNetCore.Mvc;
using DeliveryNamespace;
using Services;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private static IList<Delivery> _delivery = new List<Delivery>()
        { };

        // GET: api/delivery
        [HttpGet]
        public IEnumerable<Delivery> Get()
        {
            return _delivery;
        }

        // GET: api/delivery/{id}
        [HttpGet("{id}")]
        public ActionResult<Delivery> Get(int id)
        {
            var delivery = _deliveryService.BuscarDelivery(id);
            if (delivery == null)
            {
                return NotFound();
            }
            return delivery;
        }

        // POST: api/delivery
        [HttpPost]
        public IActionResult Post([FromBody] Delivery delivery)
        {
            if (_deliveryService.Deliveries.Any(d => d.Id == delivery.Id))
            {
                return BadRequest("Ya existe una entrega con el mismo ID.");
            }

            _deliveryService.AgregarDelivery(delivery);
            return CreatedAtAction(nameof(Get), new { id = delivery.Id }, delivery);
        }

        // PUT: api/delivery/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Delivery delivery)
        {
            var existingDelivery = _deliveryService.BuscarDelivery(id);
            if (existingDelivery == null)
            {
                return NotFound();
            }

            existingDelivery.Estado = delivery.Estado;
            existingDelivery.Productos = delivery.Productos;

            return NoContent();
        }

        // DELETE: api/delivery/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingDelivery = _deliveryService.BuscarDelivery(id);
            if (existingDelivery == null)
            {
                return NotFound();
            }

            _deliveryService.EliminarDelivery(id);
            return NoContent();
        }
    }
}
