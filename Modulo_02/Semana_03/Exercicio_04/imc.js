function calcularImc(peso, altura) {
    return peso / (altura * altura);
}

function calcular() {
    var peso = document.getElementById('peso').value;
    var altura = document.getElementById('altura').value;
    var result = calcularImc(peso, altura);
    document.getElementById('resultado').innerHTML = "<span> Seu imc é: " + result.toFixed(2) +"</span>";
}