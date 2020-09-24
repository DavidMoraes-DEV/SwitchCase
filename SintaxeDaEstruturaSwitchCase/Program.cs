using System;

namespace SintaxeDaEstruturaSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Essa estrutura alternativa é opicional a vários if-else encadeados, quando a condição envolve
            o teste do valor de uma variável.*/

            Console.WriteLine("Digite o dia da semana: ");
            int x = int.Parse(Console.ReadLine());

            switch (x) /*Essa estrutura permite que ao invés de criar um grande encadeamento de if-else
            podemos apenas realizar o switch case para testar o valor por casos separados. Vale ressaltar
            que essa estrutura é recomendada apenas quando se sabe o total de alternativas que pode ocorrer.*/
            {
                case 1:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }
        }
    }
}
