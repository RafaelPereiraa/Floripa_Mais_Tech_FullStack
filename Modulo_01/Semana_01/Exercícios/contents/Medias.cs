using Semana_01_Exercicio_01.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_01_Exercicio_01.exercicios
{
    public class Medias
    {

        public static void Executar()
        {
            Aluno[] alunos = new Aluno[5];

            for (int i = 0; i < alunos.Length; i++)
            {
                MeuConsole.Write("Digite o nome do aluno: ", true);
                string? nome = MeuConsole.ReadLine();
                MeuConsole.Write("Digite a média do aluno: ", true);
                float media = float.Parse(MeuConsole.ReadLine());

                alunos[i] = new Aluno(nome, media);
            }

            for (int i = 0; i < alunos.Length; i++)
            {
                MeuConsole.WriteLine(testaAprovacao(alunos[i]));
            }

            return;
        }

        static string testaAprovacao(Aluno aluno)
        {
            if (aluno.Media >= 6f)
            {
                return $"Parabéns, {aluno.Nome}. Você foi aprovado!";
            }
            else
            {
                return "Reprovado, se esforce mais na próxima";
            }
        }

    }

    public class Aluno
    {
        public string Nome { get; set; }
        public float Media { get; set; }

        public Aluno(string nome, float media)
        {
            Nome = nome;
            Media = media;
        }
    }
}
