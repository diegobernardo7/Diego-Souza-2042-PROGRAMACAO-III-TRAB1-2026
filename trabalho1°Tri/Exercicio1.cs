using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho1_Tri
{
    internal class Exercicio1
    {


            public static void Executar()
            {
                Console.WriteLine("=== CALCULADORA ===");

                Console.Write("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nEscolha a operação:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Resto da divisão");

                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;

                    case 4:
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine("Resultado: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        break;

                    case 5:
                        if (numero2 != 0)
                        {
                            resultado = numero1 % numero2;
                            Console.WriteLine("Resto da divisão: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

}
