using Semana_01_Exercicio_01.exercicios;
using Semana_01_Exercicio_01.utils;
using System.Linq.Expressions;

public class Menu
{
    public static void Escolhas(bool cancelar, params string[] opcoes)
    {
        
        while (true)
        {
            const int posX = 37;
            const int posY = 8;
            const int espacamentoLinhas = 1;
            int currentSelection = 0;
            UtilidadesMenu.EscreverBordasMenu();

            ConsoleKey key;


            Console.CursorVisible = false;

            do
            {

                for (int i = 0; i < opcoes.Length; i++)
                {
                    MeuConsole.SetPosition(posX, posY + i * espacamentoLinhas);

                    if (i == currentSelection)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    MeuConsole.Write(opcoes[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= 1)
                                --currentSelection;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection <= opcoes.Length - 2)
                                ++currentSelection;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            MeuConsole.Clear();
                            if (cancelar)
                                return;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            MeuConsole.CursorVisible(true);

            if (currentSelection == 5)
            {
                return;
            }

            ExecutarEscolha(currentSelection, opcoes);
        }
    }

    private static void ExecutarEscolha(int opcao, String[] opcoes)
    {
        String MensagemReload = "Pressione qualquer tecla para retornar...";
        UtilidadesMenu.EscreverBordasMenu(true);
        MeuConsole.WriteTitle(opcoes[opcao]);


        switch (opcao)
        {
            case 0:
                NumerosPrimos.Executar();
                break;
            case 1:
                OrdenaFrutas.Executar();
                break;
            case 2:
                SepararParImpar.Executar();
                break;
            case 3:
                Medias.Executar();
                break;
            case 4:
                SequenciaFibonacci.Executar();
                break;
        }

        MeuConsole.WriteLine(MensagemReload);
        MeuConsole.ReadKey(true);

        MeuConsole.Clear();
    }
}