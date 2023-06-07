import pegarNomesIbge from './ibge.js';
let lista = document.querySelector('#lista-nomes');
let listaNomesInvertidos = document.querySelector('#lista-nomes-invertidos');

console.clear();

pegarNomesIbge().then((data) => {

    let filteredData = data.filter((pessoa) => !pessoa.nome.toLowerCase().includes("a"))

    for (let pessoa in filteredData) {
        lista.innerHTML += `<li>${filteredData[pessoa].nome}</li>`;
    }
    
    for (let pessoa in filteredData.reverse()) {
        listaNomesInvertidos.innerHTML += `<li>${filteredData[pessoa].nome}</li>`;
    }
    })
    .catch((error) => {
        console.log("Ocorreu um erro:", error);
    });