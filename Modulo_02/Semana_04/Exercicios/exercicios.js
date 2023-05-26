function exercicio_01() {
    let numero = prompt("Digite um número: ");
    numero = parseInt(numero);

    if (numero > 10) {
        alert("Número é maior que 10!");
    } else if (numero <= 10) {
        alert("Número é menor ou igual a 10!");
    }
}

function exercicio_02(){    
    let mensagem = "";
    console.log("Usando while: ")
    let whileIndex = 1;
    while (whileIndex <= 20) {
        console.log(whileIndex);
        whileIndex == 20? mensagem += whileIndex : mensagem += whileIndex + ", ";
        whileIndex++;
    }
    console.log("=====================================")
    console.log("Usando for: ")
    for (let i = 1; i <= 20; i++) {
        console.log(i);
    }
    alert(`Números de 1 a 20 usando laços de repetição!\n\n ${mensagem} \n\n No console também. xD `);
}

function exercicio_03() {
    let numeros = document.getElementsByClassName("exercicio-03");

    console.log(numeros[0].value);

    if (numeros[0].value === "" || numeros[1].value === "") {
        alert("Preencha os campos!")
        numeros[0].value == ""? numeros[0].focus() : numeros[1].focus();
    } else {
        alert(soma(parseFloat(numeros[0].value), parseFloat(numeros[1].value)));
    }
}

function soma(numeroUm, numeroDois) {
    let soma = numeroUm + numeroDois;
    return("A soma dos números é: " + soma);
}

let button = document.getElementById("exercicio-04");
let date = new Date;

button.addEventListener('click', () => alert(`Botão clicado - ${date.toLocaleString()}`));

let button05c = document.getElementById("exercicio-05-c");
let button05s = document.getElementById("exercicio-05-s");
let button05r = document.getElementById("exercicio-05-r");

let objeto;


button05c.addEventListener('click', () => {
    objeto = {
        id: 1,
        nome: "teste",
        tipo: "json",
        vezesSalvo: 0
    }    
})

button05s.addEventListener('click', () => {

    alert('Salvando objeto...')
    objeto.vezesSalvo += 1;
    localStorage.setItem('objeto', JSON.stringify(objeto))
    alert(`Objeto salvo \n ${JSON.stringify(objeto)}`)
    location.reload()
})

button05r.addEventListener('click', () => {
    objeto = localStorage.getItem('objeto')
    objeto = JSON.parse(objeto)
})
