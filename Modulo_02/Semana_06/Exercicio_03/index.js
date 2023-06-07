import pegarNomesIbge from './ibge.js';
let lista = document.querySelector('#lista-nomes');
let listaNomesInvertidos = document.querySelector('#lista-nomes-invertidos');

console.clear();

pegarNomesIbge().then((data) => {
    for (let pessoa in data) {
        lista.innerHTML += `<li>${data[pessoa].nome}</li>`;
    }
    
    for (let pessoa in data.reverse()) {
        listaNomesInvertidos.innerHTML += `<li>${data[pessoa].nome}</li>`;
    }
    })
    .catch((error) => {
        console.log("Ocorreu um erro:", error);
    });