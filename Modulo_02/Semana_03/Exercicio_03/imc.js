function calcularImc(peso, altura) {
    return peso / (altura * altura);
}

let peso = prompt("Digite seu peso: ");
let altura = prompt("Digite sua altura: ");

console.log("O seu IMC é:" + calcularImc(peso, altura).toFixed(2));

