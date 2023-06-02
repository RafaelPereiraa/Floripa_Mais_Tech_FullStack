const listaDados = [
  {
    titulo: "Realidade Virtual na Educação",
    imagem:
      "https://images.unsplash.com/photo-1679913286917-9eb414421eb6?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxleHBsb3JlLWZlZWR8Nnx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=500&q=60",
    subtitulo:
      "Random string pra testar a busca blablabla",
  },
  {
    titulo: "Inteligência Artificial na Saúde",
    imagem:
      "https://images.unsplash.com/photo-1679939099392-efa3c55c2b71?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=735&q=80",
    subtitulo:
      "Subtitulo da saude",
  },
  {
    titulo: "Inovação no E-commerce",
    imagem:
      "https://images.unsplash.com/photo-1679946026929-454c89c3af10?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1740&q=80",
    subtitulo: "Artificial???",
  },
  {
    titulo: "Internet das Coisas (IoT) na Indústria",
    imagem:
      "https://images.unsplash.com/photo-1679924861986-ec54affbffda?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=764&q=80",
    subtitulo:
      "Internet das Coisas (IoT) na Indústria: como funciona e quais as vantagens?",
  },
  {
    titulo: "Filmes de Ficção Científica",
    imagem:
      "https://images.unsplash.com/photo-1679947096495-881433436c39?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80",
    subtitulo:
      "Filmes de Ficção Científica: como funciona e quais as vantagens?",
  },
  {
    titulo: "Séries de Fantasia Épica",
    imagem:
      "https://images.unsplash.com/photo-1679952418656-d10950ac49e0?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=687&q=80",
    subtitulo: "Séries de Fantasia Épica: como funciona e quais as vantagens?",
  },
  {
    titulo: "Música Pop dos Anos 90",
    imagem:
      "https://images.unsplash.com/photo-1679926820642-4cbac3f6d1b7?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80",
    subtitulo: "Música Pop dos Anos 90: como funciona e quais as vantagens?",
  },
  {
    titulo: "Quadrinhos de Super-heróis",
    imagem:
      "https://images.unsplash.com/photo-1679908696891-44a6b5c96347?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=687&q=80",
    subtitulo:
      "Quadrinhos de Super-heróis: como funciona e quais as vantagens?",
  },
  {
    titulo: "Livros de Ficção Científica",
    imagem:
      "https://images.unsplash.com/photo-1679913969285-64f089885005?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1074&q=80",
    subtitulo:
      "Livros de Ficção Científica: como funciona e quais as vantagens?",
  },
];

if (sessionStorage.getItem("listaDados") == null) {
  sessionStorage.setItem("listaDados", JSON.stringify(listaDados));
}

let listaDeDados = JSON.parse(sessionStorage.getItem("listaDados"));

function gerarCards(dados) {
  let listagemCards = document.getElementById("listagem-cards");
  listagemCards.innerHTML = "";
  dados.forEach((dado, index) => {
    listagemCards.innerHTML += `
    <div id=card_${index} class="card" >
      <div class="card-titulo">${dado.titulo}</div>
      <img src="${dado.imagem}" alt="...">
      <div class="card-subtitulo">${dado.subtitulo}</div>
    </div>
    `;
  });
}

document.querySelector(".busca > input").addEventListener("keyup", (e) => {
  let dadosFiltrados = []
    listaDeDados.forEach((dado) => {
      if (dado.titulo.toLowerCase().includes(e.target.value.toLowerCase()) || dado.subtitulo.toLowerCase().includes(e.target.value.toLowerCase())) {
        dadosFiltrados.push(dado) 
      }    
    })
    if (e.target.value == "") {
      dadosFiltrados = listaDeDados
    }
    gerarCards(dadosFiltrados)
  }
)

document.querySelector(".busca > button").addEventListener("click", (e) => {
  let dadosFiltrados = []
  let input = prompt("Digite o que deseja buscar")
    listaDeDados.forEach((dado) => {
      if (dado.titulo.toLowerCase().includes(input.toLowerCase()) || dado.subtitulo.toLowerCase().includes(input.toLowerCase())) {
        dadosFiltrados.push(dado)
      }
    })
    if (input == "") {
      dadosFiltrados = listaDeDados
    }
    document.querySelector(".busca > input").value = input
    gerarCards(dadosFiltrados)
  }
)


gerarCards(listaDeDados);