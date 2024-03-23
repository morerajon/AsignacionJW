

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




