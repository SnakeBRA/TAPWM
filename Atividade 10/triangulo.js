var a = parseFloat(prompt("Informe um número A: "));
var b = parseFloat(prompt("Informe um número B: "));
var c = parseFloat(prompt("Informe um número C: "));

if(Number.isNaN(a, b, c)){
   alert("Por favor insira apenas números nos valores.")
}

  if(a + b > c && a + c > b && b + c > a){
     alert("Os três valores formam um triângulo.")

     if(a == b && a == c)
     alert("É um triângulo Equilátero.")

     else if(a == b || a == c || b == c)
     alert("É um triângulo Isósceles.")

     else
     alert("É um triângulo Escaleno.")
  }

  else
  alert("Os três valores não forma um triângulo.")
