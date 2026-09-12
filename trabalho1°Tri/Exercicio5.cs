using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho1_Tri
{
    internal class Exercicio5
    {

            public static void Executar()
            {
                Console.WriteLine("=== FAIXA ETÁRIA ===");

                Console.Write("Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 0 && idade <= 19)
                {
                    Console.WriteLine("Faixa etária: Jovem");
                }
                else if (idade >= 20 && idade <= 59)
                {
                    Console.WriteLine("Faixa etária: Adulto");
                }
                else if (idade >= 60)
                {
                    Console.WriteLine("Faixa etária: Idoso");
                }
                else
                {
                    Console.WriteLine("Idade inválida.");
                }
            }
        }


    }

