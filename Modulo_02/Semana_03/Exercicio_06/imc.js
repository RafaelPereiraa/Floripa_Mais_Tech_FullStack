const FORMCONTENT = document.getElementById("lofiForm").innerHTML;
let tabelaContent = document.getElementById("tabela-resultados");
console.log(JSON.parse(localStorage.getItem("linha")));
let tabelaSalva = JSON.parse(localStorage.getItem("linha"));

if (tabelaSalva !== null) {
  tabelaContent.innerHTML = tabelaSalva;
  tabelaContent.removeAttribute("hidden");
}

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
  let faixa = faixaImc(result)
  let form = document.getElementById("lofiForm");
  let tabelaResult = document.getElementById("tabela-resultados");

  form.innerHTML = `${faixa}`+FORMCONTENT;
  document.getElementById("resultado").innerHTML = "<span> Seu imc é: " + result.toFixed(2) + "</span>";
  tabelaResult.removeAttribute("hidden");
  
  let novaRow = document.createElement("tr");
  novaRow.classList.add("linhas");
  let novaCell1 = document.createElement("td");
  novaCell1.innerHTML = altura;
  let novaCell2 = document.createElement("td");
  novaCell2.innerHTML = peso;
  let novaCell3 = document.createElement("td");
  novaCell3.innerHTML = result;
  let novaCell4 = document.createElement("td");
  novaCell4.innerHTML = faixa;
  novaRow.appendChild(novaCell1);
  novaRow.appendChild(novaCell2);
  novaRow.appendChild(novaCell3);
  novaRow.appendChild(novaCell4);
  tabelaResult.appendChild(novaRow);



  localStorage.setItem("linha", JSON.stringify(tabelaResult.innerHTML));

  console.log()
}
