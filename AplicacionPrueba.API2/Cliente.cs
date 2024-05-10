namespace AplicacionPrueba.API
{
    public class Cliente
    {
        public int rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
    }
            public class ClienteService
    {
        public IList<Cliente> Clientes { get; set; }
        
        public Cliente BuscarCliente(int rut)
        {
            return Clientes.FirstOrDefault(c => c.rut == rut);
        }
        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
        public void EliminarCliente(int rut)
        {
            var cliente = BuscarCliente(rut);
            if (cliente != null)
            {
                Clientes.Remove(cliente);
            }
        }
    }
}
