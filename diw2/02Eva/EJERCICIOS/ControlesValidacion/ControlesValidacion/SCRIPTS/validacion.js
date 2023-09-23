function validarLetra(source, arguments) {
    let dni = arguments.Value;

    let dniLimpio = dni.replace(/[\. ,:-]+/g, "");

    if (dniLimpio.length != 9) {
        alert("no es el tamaño correcto");
    }
    let numero = dniLimpio.substr(0, dni.length - 1);
    let letra = dni.substr(dni.length - 1, 1);
    numero = numero % 23;
    let cadena = 'TRWAGMYFPDXBNJZSQVHLCKET';
    cadena = cadena.substring(numero, numero + 1);
    if (cadena != letra) {
        arguments.IsValid = false;
    }
}

