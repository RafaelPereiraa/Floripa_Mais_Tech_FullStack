using System;

class Program
{
    static void Main(string[] args)
    {
        FileInfo arquivo = null;
        string nomeArquivo;
        try
        {
            try
            {
                Console.WriteLine("Digite o nome do arquivo: ");
                nomeArquivo = Console.ReadLine();
                arquivo = new FileInfo(nomeArquivo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu um erro - " + ex.Message);
                Console.WriteLine("Criando Arquivo Padrão");
                nomeArquivo = "Default.txt";
            }            
            using (StreamWriter stream = File.AppendText(nomeArquivo))
            {
                Console.WriteLine("O que deseja escrever no arquivo?");
                stream.WriteLine(Console.ReadLine());
            }
        } catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            Console.Clear();
            Console.WriteLine("--- Encerrando ---");
            arquivo = null;
        }

    }
}