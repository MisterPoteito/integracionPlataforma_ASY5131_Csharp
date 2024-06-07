// JavaScript para el manejo del modal
document.addEventListener('DOMContentLoaded', (event) => {
    // Seleccionamos el modal por su ID
    var modal = document.getElementById('myModal');
    // Seleccionamos el botón de cierre del modal por su clase
    var span = document.getElementsByClassName('close')[0];

    // Añadimos un evento de clic al botón de cierre
    span.onclick = function() {
        // Al hacer clic en el botón de cierre, ocultamos el modal
        modal.style.display = 'none';
    }

    // Añadimos un evento de clic al objeto ventana
    window.onclick = function(event) {
        // Si el clic ocurre fuera del contenido del modal, ocultamos el modal
        if (event.target == modal) {
            modal.style.display = 'none';
        }
    }

    // Añadimos un evento de clic al botón de finalizar
    document.getElementById('finalizar').onclick = function() {
        // Al hacer clic en el botón de finalizar, mostramos el modal
        modal.style.display = 'block';
    }

    // Añadimos un evento de clic al botón de agregar producto
    document.getElementById('agregar-producto').onclick = function() {
        // Obtenemos el valor de la cantidad y el precio desde los campos de entrada
        var cantidad = document.getElementById('cantidad').value;
        var precio = document.getElementById('precio').value;
        // Calculamos el total multiplicando cantidad por precio y lo mostramos en el campo total
        document.getElementById('total').value = (cantidad * precio).toFixed(2);
    }
});
