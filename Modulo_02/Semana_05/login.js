// Testa se já existe "pseudo-banco" no sessionStorage, se não existir, cria um
sessionStorage.getItem("users") == null ? sessionStorage.setItem("users", JSON.stringify([])) : null;

// Pega os elementos do DOM
let inputEmail = document.getElementById("email");
let inputPassword = document.getElementById("password");

// Pega o botão de login
let loginBtn = document.getElementById("login-btn");

loginBtn.addEventListener("click", source => {
    source.preventDefault();
    let users = JSON.parse(sessionStorage.getItem("users"));
    let email = inputEmail.value;
    let password = inputPassword.value;
    let user = users.find(user => user.email == email && user.password == password);
    if (user != null) {
        sessionStorage.setItem("loggedUser", JSON.stringify(user));
        window.location.href = "home.html";
    } else {
        alert("Email ou senha incorretos");
    }
});
