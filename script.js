

function redireccionar() {
    // Redirige a la página deseada
    window.location.href = "inicio.html";
}

function redireccionar2() {
    // Redirige a la página deseada
    window.location.href = "vym.html";
}

function OcultarMostrar() {
    const passwordInput = document.getElementById('encryptedHTML');
    const icon = document.querySelector('bx'); // Selecciona el ícono con la clase 'bx'

    if (passwordInput.type === "password") {
        passwordInput.type = "text";
        icon.classList.remove('bxs-show');
        icon.classList.add('bxs-hide');
    } else {
        passwordInput.type = "password";
        icon.classList.remove('bxs-hide');
        icon.classList.add('bxs-show');
    }
}

document.addEventListener('DOMContentLoaded', function () {
    document.querySelector('#btnConvertirPDF').addEventListener('click', function () {
        html2canvas(document.querySelector('#contenido')
        , {
            scale: 0.8, // Escala la captura al 80%
            logging: true, // Habilita el registro para depuración
            width: 1000 // Ancho del canvas
        }).then((canvas) => {
            let base64image = canvas.toDataURL('image/png');
            let pdf = new jsPDF('p', 'px', [canvas.width-5, canvas.height]);
            pdf.addImage(base64image, 'PNG', 0, 0, canvas.width, canvas.height);
            pdf.save('estructura1.pdf');
        });
    });
});



// Obtener todos los elementos con la clase "tiempo"
var elementosTiempo = document.getElementsByClassName("tiempo");

// Variable para controlar si se ha mostrado la alerta
var alertaMostrada = false;

// Iterar sobre la colección de elementos y agregar el evento blur a cada uno
for (var i = 0; i < elementosTiempo.length; i++) {
    elementosTiempo[i].addEventListener("blur", function() {
        var valor = parseInt(this.value.trim());
        if (!isNaN(valor) && valor >= 0 && valor <= 60) { // Verifica si el valor es un número válido entre 0 y 60
            this.value = valor + " Mins.";
        } else {
            if (!alertaMostrada) {
                alert("Por favor, ingrese un número válido entre 0 y 60.");
                alertaMostrada = true;
            }
            this.value = ""; // Vaciar el campo si el valor ingresado no es válido
            this.focus(); // Devolver el foco al input para que el usuario pueda corregir
        }
    });

    // Agregar event listener para el evento input que limpia la alertaMostrada
    elementosTiempo[i].addEventListener("input", function() {
        alertaMostrada = false; // Limpiar la alertaMostrada cuando el usuario continúa interactuando con el input
    });
}