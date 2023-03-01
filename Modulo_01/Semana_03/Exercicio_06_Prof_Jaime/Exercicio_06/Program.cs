using Exercicio_06;

Produto produto = new Produto();
produto.nome = "calculadora";
produto.VerificarEstoque();
Console.WriteLine("O nome do produto é: " + produto.nome);

ProdutoFinanceiro produtoFinanceiro = new ProdutoFinanceiro();

produtoFinanceiro.nome = "Lapis";
produtoFinanceiro.VerificarEstoque();
produtoFinanceiro.Acesso();