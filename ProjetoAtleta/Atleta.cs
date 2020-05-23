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
        private int idade;
        private double altura;
        private double peso;

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
                    throw new Exception("O nome deve ser preenchido!");
                }
            }

            get { return this.nome; }
        }

        public int Idade
        {
            set
            {
                if (value >= 1)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade deve ser positiva!");
                }
            }

            get { return this.idade; }
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
                    throw new Exception("A altura deve ser maior que 1.00 metro!");
                }
            }

            get { return this.altura; }
        }

        public double Peso
        {
            set
            {
                if (value >= 1)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso deve ser positivo!");
                }
            }

            get { return this.peso; }
        }

        public string ImprimirDados()
        {
            return " \n\nNome: " + this.nome +
            " \n\nIdade: " + this.idade;
        }

        public double CalculaIMC()
        {
            return this.peso / (this.altura * this.altura) * 10000;
        }
    }
}