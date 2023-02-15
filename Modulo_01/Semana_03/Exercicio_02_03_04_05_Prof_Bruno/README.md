# Módulo 01 

## Semana 03

Atendendo os requisitos dos exercícios propostos dessa semana, foi implementado:

    1. Instanciação enviando os dados da classe
    2. Campos com modificador Private
    3. Criação de construtor recebendo conta e agencia aleatórios entre 0000 e 9999
    4. Criação de método de transferência

### Extras
- Todos os métodos foram atualizados, mantendo as mesmas usabilidades na Semana 02.
- Criado Classes de menu para controle de fluxo do programa fora do Program.cs
- Separado o enum do arquivo da classe contaBancaria
- Criado arquivo de mockup para popular as contas facilitando testes (usando um construtor diferente, apenas a título de estudo)
- Criadas funções extras, para gerenciar:
    - Criação de conta (CriarConta.cs) - Coleta os dados e cria uma conta conforme as seleções de:
        1. Criar conta definindo todos os parametros.
        2. Criar conta definindo apenas nome, tipo, agencia e senha
        3. Criar conta definindo apenas nome, tipo e senha.
    - Escolhas do menu (Escolhas.cs) - Executa a opção escolhida no menu inicial
    - Procurar conta (FindConta.cs) - Procura na lista de contas recebida se existe uma conta com o número digitado - caso positivo, retorna essa conta para que seja manipulada
    - Listar contas (ListarContas.cs) - Lista as contas existentes apresentando id/número/agência
    - Checagem de numeros (CheckNumber.cs) - Confere se os valores digitados condizem com as opções de menu e tipos de atributos da classe ContaBancaria.

### TODO/Futuro
- Melhorar métodos de filtragem de caracteres
- Persistência de dados
- Menu selecionável por setas

#
## Semana 02 

Atendendo os requisitos dos exercícios propostos dessa semana, foi implementado:

    1. Classe conta bancária com os atributos:
        - int id
        - int numero
        - string nome do titular
        - double saldo iniciando em 0 na instanciação do objeto
        - tipos de conta com enum corrente/poupança

    2. Criado o método para depósito com as condições:
    - Valores > 0 recebido no método


    3. Criado método para saque com as condições:
    - Valores > 0

    4. Implementado Visualização de saldo.



### Extras

- Implementado campo senha para a conta
- Implementado a geração de múltiplas contas, através de um id auto incrementável iniciado em 0 a título de estudo para teste das funções a seguir:
    - Depósito para conta de id correspondente
    - Saque da conta de id correspondente através de validação com senha
    - Exibição de saldo de conta com id correspondente
- Validação básica dos tipos digitados para cada atributo (numero só aceitando números, etc)

### TODO/Futuro
- Melhorar as filtragens de caracteres incompativeis com atributos
- Implementar busca através do número da conta [Concluido]
- Persistência de dados
