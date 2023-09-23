function validarCorreo(source, args) {
    var correo = args.Value;
    if (correo=="marta.torre@zabalburu.org" || correo=="inigo.chueca@zabalburu.org" ) {
        args.IsValid = true;
    } else {
        args.IsValid = false;
    }

}