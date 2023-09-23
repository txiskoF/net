function validarLetra(source, arguments) {
    //alert("estoy en validarLetra " + arguments.Value);
    let dni = arguments.Value;
    // /[\." " ,:-]+/g
    dni = dni.replace(/ /g, "");
    dni = dni.replace(/-/g, "");
    dni = dni.replace(/\./g, "");
    //dni.replace()

    /*if (dniTratado.length != 9) {
        alert("la lognitud no es correcta");
    }
    */
    let numero = dni.substring(0, dni.length - 1);
    let letra = dni.substr(dni.length - 1, 1);
    numero = numero % 23;
    let cadena = 'TRWAGMYFPDXBNJZSQVHLCKET';
    cadena = cadena.substr(numero, 1);
    if (cadena != letra) {
        arguments.IsValid = false;
    } else {
         arguments.IsValid = true;
    }

   
}