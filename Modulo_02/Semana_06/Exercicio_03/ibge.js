export default function pegarNomesIbge() {
  return fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking")
    .then((response) => {
      return response.json();
    })
    .catch((error) => {
      console.log("Ocorreu um erro:", error);
    });
}
