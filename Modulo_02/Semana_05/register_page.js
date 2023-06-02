// Pega os elementos do DOM
let inputEmail = document.getElementById("email")
let inputPassword = document.getElementById("password")
let inputConfirmPassword = document.getElementById("confirm-password")
let registerBtn = document.getElementById("register-btn")
let regexValidarEmail = /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/g // Regex para validar email
let regexValidarSenha = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{10,}$/g // Regex para validar senha (mínimo 10 caracteres, pelo menos uma letra maiúscula, uma minúscula e um número)

// Eventos - Todos mais ou menos iguais, só validando com base no regex
inputEmail.addEventListener("keypress", source => {
    source.preventDefault();
    inputEmail.value += source.key;
    let email = inputEmail.value;
    if (regexValidarEmail.test(email)) {
        console.log("Email válido");
        inputEmail.classList.remove("invalid");
        inputEmail.classList.add("valid");
    }
});

inputEmail.addEventListener("blur", () => {
    let email = inputEmail.value;
    if (email.match(regexValidarEmail)) {
        inputEmail.classList.remove("invalid");
        inputEmail.classList.add("valid");
    } else {
        inputEmail.setCustomValidity("Email inválido");
        inputEmail.reportValidity();
        inputEmail.classList.remove("valid");
        inputEmail.classList.add("invalid");
    }
});

inputPassword.addEventListener("keypress", source => {
    source.preventDefault();
    inputPassword.value += source.key;  
});

inputPassword.addEventListener("blur", () => {
    let senha = inputPassword.value;
    if (senha.match(regexValidarSenha)) {
        inputPassword.classList.remove("invalid");
        inputPassword.classList.add("valid");
    } else {
        inputPassword.setCustomValidity("Senha inválida - Precisa conter 10 letras, pelo menos uma maiúscula, uma minúscula e um número");
        inputPassword.reportValidity();
        inputPassword.classList.remove("valid");
        inputPassword.classList.add("invalid");
    }
});

inputConfirmPassword.addEventListener("keypress", source => {
    source.preventDefault();
    inputConfirmPassword.value += source.key;  
});

inputConfirmPassword.addEventListener("blur", () => {
    let senha = inputPassword.value;
    let confirmSenha = inputConfirmPassword.value;
    if (senha == confirmSenha && senha.match(regexValidarSenha) && confirmSenha.match(regexValidarSenha)) {
        inputConfirmPassword.classList.remove("invalid");
        inputConfirmPassword.classList.add("valid");
    } else {
        inputConfirmPassword.setCustomValidity("Senha não confere");
        inputConfirmPassword.reportValidity();
        inputConfirmPassword.classList.remove("valid");
        inputConfirmPassword.classList.add("invalid");
    }
});

registerBtn.addEventListener("click", source => {
    source.preventDefault();
    if (inputEmail.classList.contains('valid') && inputPassword.classList.contains('valid') && inputConfirmPassword.classList.contains('valid')) {
        newUser = {
            email: inputEmail.value,
            password: inputPassword.value
        };

        let users = JSON.parse(sessionStorage.getItem("users"));
        users.push(newUser);
        sessionStorage.setItem("users", JSON.stringify(users));

        alert("Cadastro realizado com sucesso!");
        window.location.href = "login.html";
    } else {
        alert("Preencha os campos corretamente!");
        if (!inputConfirmPassword.classList.contains('valid')) {
            inputConfirmPassword.classList.add("invalid");
            inputConfirmPassword.focus();
        }
        if (!inputPassword.classList.contains('valid')) {
            inputPassword.classList.add("invalid");
            inputPassword.focus();
        }
        if (!inputEmail.classList.contains('valid')) {
            inputEmail.classList.add("invalid");
            inputEmail.focus();
        }
    }
});
