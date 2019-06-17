using System;
using System.Globalization;

namespace gasto_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {

            int tempogastoemHoras, velocidadeMedia, distancia;

            double quantidadedeLitros;

            Console.WriteLine("DIGITE O TEMPO GASTO NA VIAGEM EM HORAS: ");
            tempogastoemHoras = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A VELOCIDADE EM KM/H: ");
            velocidadeMedia = int.Parse(Console.ReadLine());


            distancia = tempogastoemHoras * velocidadeMedia;

            quantidadedeLitros = distancia / 12.0;

            Console.WriteLine("O VALOR GASTO EM COMBUSTIVEL É DE: " + quantidadedeLitros.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
