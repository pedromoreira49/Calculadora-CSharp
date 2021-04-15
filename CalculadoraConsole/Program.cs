using System;
using ModuloCalculadora;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var continuar = true;
            while (continuar)
            {
                double resultado = 0;

                Console.WriteLine("Escolha a operação: 1-Soma 2-Subtração 3-Multiplicação 4-Divisão");
                var operacao = Console.ReadLine();

                Console.WriteLine("Digite um número: ");
                var numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite outro número: ");
                var numero2 = double.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case "1":
                        resultado = OperacoesAritmeticas.Adicao(numero1, numero2);
                        break;
                    case "2":
                        resultado = OperacoesAritmeticas.Subtracao(numero1, numero2);
                        break;
                    case "3":
                        resultado = OperacoesAritmeticas.Multiplicacao(numero1, numero2);
                        break;
                    case "4":
                        resultado = OperacoesAritmeticas.Divisao(numero1, numero2);
                        break;
                    default:
                        Console.WriteLine("Insira uma operação válida.");
                        break;
                }

                Console.WriteLine("Resultado: " + resultado);

                Console.WriteLine();
                Console.Write("Deseja continuar? S/N  ");
                if(Console.ReadLine() == "N")
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
