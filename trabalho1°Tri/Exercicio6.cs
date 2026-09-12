using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho1_Tri
{
    internal class Exercicio6
    {

   
            public static void Executar()
            {
                Console.WriteLine("=== CADASTRO DE LIVRO ===");

                Console.Write("Digite o título: ");
                string titulo = Console.ReadLine();

                Console.Write("Digite o autor: ");
                string autor = Console.ReadLine();

                Console.Write("Digite o valor: ");
                double valor = double.Parse(Console.ReadLine());

                Console.WriteLine("\n=== DADOS DO LIVRO ===");
                Console.WriteLine("Título: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Valor: R$ " + valor);
            }
        }

    }
