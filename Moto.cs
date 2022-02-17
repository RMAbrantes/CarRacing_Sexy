using System;

namespace CarRacing
{
    class Moto : Veiculo
    {
        public int NumRodas { get; set; }

        public Moto()
        {

        }

        public Moto(string marca, ConsoleColor cor) 
        {
            Cor = cor;
            Marca = marca;
        }

        public override string ToString()
        {
            // exemplo: .....Seat (5 Km)
            var kmsPercorridos = "".PadLeft(Kms, '-');
            return $"{kmsPercorridos} {Marca} ({Kms} kms)";
        }
    }
}
