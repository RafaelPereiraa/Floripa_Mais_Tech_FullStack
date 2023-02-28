using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_01_02_03_04_05_06.Models
{
    internal class Cliente
    {
        public string nome { get; private set; }
        public DateTime nascimento { get; private set; }
        public string profissao{ get; private set; }
        public EstadoCivil estadoCivil{ get; private set; }
        public TipoPessoa tipoPessoa{ get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, EstadoCivil estadoCivil, TipoPessoa tipoPessoa)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.profissao = profissao;
            this.estadoCivil = estadoCivil;
            this.tipoPessoa = tipoPessoa;
        }

        public Cliente()
        {
        }

        public override string? ToString()
        {
            return nome;
        }
    }
}
