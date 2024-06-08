using DeliveryNamespace;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class DeliveryService
    {
        public IList<Delivery> Deliveries { get; set; } = new List<Delivery>();

        public Delivery BuscarDelivery(int id)
        {
            return Deliveries.FirstOrDefault(d => d.Id == id);
        }

        public void AgregarDelivery(Delivery delivery)
        {
            Deliveries.Add(delivery);
        }

        public void EliminarDelivery(int id)
        {
            var delivery = BuscarDelivery(id);
            if (delivery != null)
            {
                Deliveries.Remove(delivery);
            }
        }
    }
}
