function procura(texto) {
    var textoMinusc = texto.toLowerCase();
  
    var contadorA = 0;
    for (var i = 0; i < textoMinusc.length; i++) {
      if (textoMinusc[i] === 'a') {
        contadorA++;
      }
    }
  
    console.log(`Quantidade de letras 'A' encontradas: ${contadorA}`);
  }
  
  procura("Você sabia que J1407b é um exoplaneta?");
  