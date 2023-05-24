const FORMCONTENT = document.getElementById("lofiForm").innerHTML;

function calcularImc(peso, altura) {
  return peso / (altura * altura);
}

function faixaImc(imc) {
  if (imc < 18.5) {
    return "<div class='abaixo'>Abaixo do peso</div>";
  } else if (imc >= 18.5 && imc < 25) {
    return "<div class='normal'>Peso normal</div>";
  } else if (imc >= 25 && imc < 30) {
    return "<div class='sobrepeso'>Sobrepeso</div>";
  } else if (imc >= 30 && imc < 35) {
    return "<div class='obesidade-um'>Obesidade grau 1</div>";
  } else if (imc >= 35 && imc < 40) {
    return "<div class='obesidade-dois'>Obesidade grau 2</div>";
  } else if (imc >= 40){
    return "<div class='obesidade-tres'>Obesidade grau 3</div>";
  }
}

function calcular() {
  var peso = document.getElementById("peso").value;
  var altura = document.getElementById("altura").value;
  var result = calcularImc(peso, altura);
  let form = document.getElementById("lofiForm");
  form.innerHTML = `${faixaImc(result)}`+FORMCONTENT;
  document.getElementById("resultado").innerHTML = "<span> Seu imc é: " + result.toFixed(2) + "</span>";
}
