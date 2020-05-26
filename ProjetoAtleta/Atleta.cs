using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private DateTime dataNascimento;
        private double altura, peso;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }

        public DateTime DataNascimento
        {
            set { this.dataNascimento = value; }
            get { return this.dataNascimento; }
        }

        public double Peso
        {
            set
            {
                if (value >= 30.00)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("Seu peso deve ser acima de 30Kg.");
                }
            }
            get { return this.peso; }
        }

        public double Altura
        {
            set
            {
                if (value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura deve ser acima de 1m.");
                }
            }
            get { return this.altura; }
        }

        public string ImprimeDados()
        {
            return "Dados da pessoa: \n\nNome: " +
                    this.nome + "\nData de Nascimento: " +
                    this.dataNascimento.ToString("dd/MM/yyyy") +
                    "\nAltura: " + this.altura.ToString("0.00") + " m" +
                    "\nPeso: " + this.peso.ToString() + " Kg.";
        }

        public int CalcularIdade()
        {
            return DateTime.Now.Year - this.dataNascimento.Year;
        }

        public double CalcularIMC()
        {
            return this.peso / (Math.Pow(this.altura, this.altura));
        }
    }
}
