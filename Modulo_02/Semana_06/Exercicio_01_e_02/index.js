let listaNomes = [];
let lista = document.querySelector('#lista-nomes');
let listaNomesInvertidos = document.querySelector('#lista-nomes-invertidos');

fetch('https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking')
  .then(response => response.json())
  .then(data => {
    listaNomes = data
    for (let pessoa in data) {
        lista.innerHTML += `<li>${data[pessoa].nome}</li>`;
    }

    for (let pessoa in data.reverse()) {
        listaNomesInvertidos.innerHTML += `<li>${data[pessoa].nome}</li>`;
    }
  })
  .catch(error => {
    console.log('Ocorreu um erro:', error);
  });
