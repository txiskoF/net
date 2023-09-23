function validarDNI(source, args) {
    var letras = 'TRWAGMYFPDXBNJZSQVHLCKE';
    var dni = args.Value;
    var miletra = dni.substr(dni.length - 1, 1);
    if (dni.indexOf(".")!==-1) {
        dni=dni.replace(/\./g,"");
    } else if (dni.indexOf(" ")!== -1) {
        dni= dni.replace(/\ /g, "");
    }
    var numero = dni.substr(0, 8);
    var resto = numero % 23;
    var letra = letras.substr(resto, 1);
    if (miletra===letra) {
        args.IsValid = true;
    } else {
        args.IsValid = false;
    }


}