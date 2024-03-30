

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

v

