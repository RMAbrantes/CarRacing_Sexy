using System.Collections.Generic;
using System;

namespace CarRacing
{
    class Pista
    {
        public int Comprimento { get; private set; }
        public List<Carro> Carros { get; private set; }

        public Pista(int comprimento, List<Carro> carros)
        {
            Comprimento = comprimento;
            Carros = carros;
        }

        public int NumeroCarros
        {
            get
            {
                return (Carros == null) ? 0 : Carros.Count;
            }
        }

        public void Print(bool clear = true)
        {
            if (clear)
                Console.Clear();

            var contorno = "".PadRight(Comprimento, '═');

            Console.WriteLine(contorno);

            foreach (var carro in Carros)
                carro.Print();

            System.Console.WriteLine(contorno);
        }

        public void MaisUmaVolta()
        {
            foreach (var carro in Carros)
                carro.Move();
        }

        public bool HaVencedor()
        {
            foreach (var carro in Carros)
            {
                if (carro.Kms >= Comprimento)
                    return true;
            }

            return false;
        }

        public Carro GetVencedor()
        {
            foreach (var carro in Carros)
            {
                if (carro.Kms >= Comprimento)
                    return carro;
            }

            return null;
        }

        public List<Carro> GetVencedores()
        {
            var vencedores = new List<Carro>();

            foreach (var carro in Carros)
            {
                if (carro.Kms >= Comprimento)
                    vencedores.Add(carro);
            }

            return vencedores;
        }
    }
}