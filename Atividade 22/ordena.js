function ordena(n1, n2, n3, n4, n5) {
    var numeros = [n1, n2, n3, n4, n5];
  
    numeros.sort(function(a, b) {
      return b - a;
    });

    console.log("Números em ordem decrescente:", numeros);
  }
  
  ordena(5, 32, 86, 661, 33);
  