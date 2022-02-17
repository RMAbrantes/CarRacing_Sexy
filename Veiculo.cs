using System;

namespace CarRacing
{
    class Veiculo : object
    {
        Random rnd = new Random();

        public ConsoleColor Cor { get; set; }
        public string Marca { get; set; }
        public int Kms { get; set; }

        public Veiculo(int kms)
        {

            Console.WriteLine($"A construir um veículo com {kms} kms");
        }

        public Veiculo()
        {

        }

        public void Print()
        {
            Console.ForegroundColor = Cor;

            Console.WriteLine(this.ToString());

            Console.ResetColor();
        }

        /// <summary>
        /// Faz o veículo "andar" um determinado n.º de kms
        /// </summary>
        internal void Move()
        {
            var kmsPercorridos = rnd.Next(1, 10);
            Kms += kmsPercorridos;
        }
    }
}