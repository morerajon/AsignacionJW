

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
        const contenido = document.querySelector('#contenido');
        const contenidoRect = contenido.getBoundingClientRect(); // Obtener dimensiones del contenido

        html2canvas(contenido, {
            scale: 1, // Escala la captura al 80%
            logging: true, // Habilita el registro para depuración
            width: contenidoRect.width, // Ancho del canvas igual al ancho del contenido
            height: contenidoRect.height // Alto del canvas igual al alto del contenido
        }).then((canvas) => {
            let base64image = canvas.toDataURL('image/png');
            let pdf = new jsPDF('p', 'px', [canvas.width, canvas.height], true); // Con true se activa el autoPaging
            pdf.addImage(base64image, 'PNG', 0, 0, canvas.width, canvas.height);
            pdf.save('estructura1.pdf');
        });
    });
});


document.getElementById("botonClonar").addEventListener("click", function() {
    // Clonar el div original
    var divOriginal = document.getElementById("divOriginal");
    var divClonado = divOriginal.cloneNode(true);
    
    // Agregar el div clonado después del div original
    divOriginal.parentNode.insertBefore(divClonado, divOriginal.nextSibling);
});


document.getElementById("botonClonar2").addEventListener("click", function() {
    // Clonar el div original
    var divOriginal = document.getElementById("divOriginal2");
    var divClonado = divOriginal.cloneNode(true);
    
    // Agregar el div clonado después del div original
    divOriginal.parentNode.insertBefore(divClonado, divOriginal.nextSibling);
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

function expandirBoton() {
    document.getElementById("icono").textContent = "Agregar semana";
  }
  
  function contraerBoton() {
    document.getElementById("icono").textContent = "+";
  }

  function duplicarDiv(button) {
    // Crear un nuevo div y copiar el contenido del div original
    var originalDiv = document.getElementById('originalDiv');
    var clonedDiv = originalDiv.cloneNode(true);

    // Remover el id del div clonado para evitar duplicación de IDs
    clonedDiv.removeAttribute('id');

    // Pegar el div clonado al final del div original
    originalDiv.parentNode.appendChild(clonedDiv);

    // Mover el botón debajo del div clonado
    setTimeout(function() {
        button.parentNode.removeChild(button); // Eliminar el botón del lugar actual
        document.body.appendChild(button); // Mover el botón al final del documento
    }, 0);
}







function showButton(container1) {
    var button = container1.querySelector('.innerButton');
    button.style.display = 'block';
    var button2 = container1.querySelector('.innerButton2');
    button2.style.display = 'block';
}

function hideButton(container1) {
    var button = container1.querySelector('.innerButton');
    button.style.display = 'none';
    var button2 = container1.querySelector('.innerButton2');
    button2.style.display = 'none';
}


