document.addEventListener('DOMContentLoaded', (event) => {
 

 
    const Estados = {
        0: 'Preparación',
        1: 'Enviado',
        2: 'Entregado'
    };

    const delivery = {
        id: 1,
        estado: 1, 
        productos: [
            { id: 1, nombre: 'Producto 1', cantidad: 2 },
            { id: 2, nombre: 'Producto 2', cantidad: 1 }
        ]
    };

 
    function mostrarEstado() {
        document.getElementById('estado').textContent = Estados[delivery.estado];
    }


    mostrarEstado();
});
