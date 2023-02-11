# Módulo 01 - Semana 02

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



## Extras

- Implementado campo senha para a conta
- Implementado a geração de múltiplas contas, através de um id auto incrementável iniciado em 0 a título de estudo para teste das funções a seguir:
    - Depósito para conta de id correspondente
    - Saque da conta de id correspondente através de validação com senha
    - Exibição de saldo de conta com id correspondente
- Validação básica dos tipos digitados para cada atributo (numero só aceitando números, etc)

## TODO/Futuro
- Melhorar as filtragens de caracteres incompativeis com atributos
- Implementar busca através do número da conta
- Persistência de dados
- ... a definir ...