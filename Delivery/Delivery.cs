using EnumNamespace;
using Productos;
using System.Collections.Generic;

namespace Delivery
{
    public class Delivery
    {
        public int Id { get; set; }
        public Estados Estado { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
    }
}
