document.addEventListener('DOMContentLoaded', (event) => {
    // Obtenemos los datos de localStorage
    var nombre = localStorage.getItem('nombre');
    var rut = localStorage.getItem('rut');
    var apellido = localStorage.getItem('apellido');
    var idProducto = localStorage.getItem('idProducto');
    var nombreProducto = localStorage.getItem('nombreProducto');
    var precio = localStorage.getItem('precio');
    var descripcion = localStorage.getItem('descripcion');
    var total = localStorage.getItem('total');

    // Mostramos los datos en la sección de detalles
    document.getElementById('detalle').innerHTML = `
        <p><strong>Cliente:</strong></p>
        <p>Nombre: ${nombre}</p>
        <p>RUT: ${rut}</p>
        <p>Apellido: ${apellido}</p>
        <br>
        <p><strong>Producto:</strong></p>
        <p>ID: ${idProducto}</p>
        <p>Nombre: ${nombreProducto}</p>
        <p>Precio: ${precio}</p>
        <p>Descripción: ${descripcion}</p>
        <p>Total: ${total}</p>
    `;
});
