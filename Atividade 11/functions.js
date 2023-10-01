function maior() {
    var a = parseFloat(prompt("Informe um valor a: "));
    var b = parseFloat(prompt("Informe um valor b: "));
    var c = parseFloat(prompt("Informe um valor c: "));
    var d = parseFloat(prompt("Informe um valor d: "));

    var maiorNum = Math.max(a, b, c, d); 

    if (Number.isNaN(a, b, c, d)) {
        alert("Por favor digite um número válido.")
    }  
    alert("O valor " + maiorNum + " é o maior número!")
}

maior();

function ordemCrescente() {
    var a = parseFloat(prompt("Informe um valor a: "));
    var b = parseFloat(prompt("Informe um valor b: "));
    var c = parseFloat(prompt("Informe um valor c: "));
    var d = parseFloat(prompt("Informe um valor d: "));

    var valores = [a, b, c, d];

    if (Number.isNaN(a, b, c, d)) {
        alert("Por favor digite um número válido.")
    }

    valores.sort(function (x, y) {
        return x - y;
    });

    alert("Valores em ordem crescente: " + valores.join(", "));
}
    
ordemCrescente();