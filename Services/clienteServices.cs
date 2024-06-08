using System.Collections.Generic;
using System.Linq;

namespace Productos
{
    public class ProductoService
    {
        public IList<Producto> Productos { get; set; } = new List<Producto>();

        public Producto BuscarProducto(int id)
        {
            return Productos.FirstOrDefault(p => p.Id == id);
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void EliminarProducto(int id)
        {
            var producto = BuscarProducto(id);
            if (producto != null)
            {
                Productos.Remove(producto);
            }
        }
    }
}
