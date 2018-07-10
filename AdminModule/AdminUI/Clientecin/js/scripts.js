function caja() {
  var lista = ["Paella", "Sopa", "Sushi", "Paella", "Sopa", "Sushi"];
  var listaImg = ["img/paella.jpg", "img/sopa.jpg", "img/surimi.jpg", "img/paella.jpg", "img/sopa.jpg", "img/surimi.jpg"];
  var i;
  for (i = 0; i < lista.length; i++) {
    document.write(
     "<div class=\"col s12 m4 l4\">" +
   "<div class=\"card\">" +
       "<div class=\"card-image\">" +
          "<img class=\"materialboxed\" src=\""+ listaImg[i] + "\" >" +
          "<span class=\"card-title\">"+lista[i]+"</span>" +
          "<a class=\"btn-floating halfway-fab waves-effect waves-light red\"><i class=\"material-icons\">shopping_cart</i></a>" +
        "</div>" +
        "<div class=\"card-content\">" +
      "<p>I am a very simple card. I am good at containing small bits of information. I am convenient be.</p>" +
     "</div>" +
   "</div>" +
  "</div>"
      );
  }
}




