using Exercicio_01;

    Produto produto_um = new Produto("Calculadora", 5.75, 199);
    Produto produto_dois = new Produto();

    Console.WriteLine($"O Produto 01 tem nome: {produto_um.nome}, valor: {produto_um.preco}, quantidade: {produto_um.quantidade}");
    Console.WriteLine($"O Produto 02 tem nome: {produto_dois.nome}, valor: {produto_dois.preco}, quantidade: {produto_dois.quantidade}");