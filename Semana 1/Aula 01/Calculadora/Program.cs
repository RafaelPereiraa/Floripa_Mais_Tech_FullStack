// Libs

// Classe

// Método

// Variáveis
int opcao, numeroUm, numeroDois;
float resultado = 0;

// Entradas
Console.WriteLine("Operações \n\n" +
    "1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair\n\n" +
    "Digite a opção escolhida: "
);
opcao = int.Parse(Console.ReadLine());


// Processamento
switch (opcao)
{
    // Instruções

    case 1:
        Console.WriteLine("Operação Somar");
        Console.WriteLine("Digite o primeiro número: ");
        numeroUm= int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        numeroDois = int.Parse(Console.ReadLine());
        resultado = numeroUm + numeroDois;
        break;
    case 2:
        Console.WriteLine("Operação Subtração");
        Console.WriteLine("Digite o primeiro número: ");
        numeroUm = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        numeroDois = int.Parse(Console.ReadLine());
        resultado = numeroUm - numeroDois;
        break;
    case 3:
        Console.WriteLine("Operação Multiplicação");
        Console.WriteLine("Digite o primeiro número: ");
        numeroUm = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        numeroDois = int.Parse(Console.ReadLine());
        resultado = numeroUm * numeroDois;
        break;
    case 4:
        Console.WriteLine("Operação Divisao");
        Console.WriteLine("Digite o primeiro número: ");
        numeroUm = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        numeroDois = int.Parse(Console.ReadLine());
        resultado = (float)numeroUm / (float)numeroDois;
        break;
    case 5:
        Console.WriteLine("Saindo");
        break;
}

Console.WriteLine("Resultado: " + resultado);

// Saídas