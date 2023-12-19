
$(document).ready(function () {

    var ruta = getAbsolutePath() + "images/Inicio/";
  
    //servidor local
    if (ruta.indexOf("localhost") != -1) {
        ruta = "http://localhost:59555/images/Inicio/"
    } else {
        //ruta = "http://192.168.10.34/SisConteo/Images/Inicio/"
        ruta = "http://" + window.location.host + "/SisConteos/images/Inicio/"
    }
    /*
        Fullscreen background
    */

    var imagenes = [];

    //se cargan las imagenes de la carpeta Images/Login desde la que comienza con img1.jpg hasta la img8.jpg
    for (var i = 1; i <= 8; i++) {
        imagenes[(i - 1)] = ruta + "img" + i + ".jpg";
    }


    $.backstretch(imagenes, { duration: 5000, fade: 750 });

    /*
        Form validation
    */



});

function getAbsolutePath() {
    var loc = window.location;
    var pathName = loc.pathname.substring(0, loc.pathname.lastIndexOf('/') + 1);
    return loc.href.substring(0, loc.href.length - ((loc.pathname + loc.search + loc.hash).length - pathName.length));
}
