function GetMap() { 
 
    // Crea una instancia de un Mapa de Bing usando la Key API   
    var map = new Microsoft.Maps.Map('#myMap', { credentials: 'AgYuBE0uerBUGDd98UgIiVxXNpETDk9ws2POifvs_Dps4aw7eCHAkJ9wSGM-tTQU' }); 
 
// Creamos una variable loc pasándole la localización del lugar a visitar. // // Toda Localización se establece con dos valores: la Latitud y la Longitud. 
 
// Tomaremos de las etiquetas LblLatitud y LblLongitud del WebForm los valores // de los diferentes puntos que queremos representar.     
 
    var loc = new Microsoft.Maps.Location(document.getElementById('LblLatitud').innerText, document.getElementById('LblLongitud').innerText);     // Ahora crearemos un marcador(pin) en la localización pasada como parámetro. // Eso se hace con el método Pushpin, al que pasaremos como parámetro la  // variable con la localización deseada.    
    var pin = new Microsoft.Maps.Pushpin(loc); 
 
    // Mediante el método push de la colección Entities de la clase Map podremos añadir el marcador al mapa.     
    map.entities.push(pin); 
 
    //El método setView del objeto map se encarga de centrar el mapa en la localización deseada y hacer zoom.     
    map.setView({ center: loc, zoom: 15 });
} 
 
 