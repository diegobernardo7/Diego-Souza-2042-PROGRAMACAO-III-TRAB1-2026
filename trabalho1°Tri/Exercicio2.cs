using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho1_Tri
{
    internal class Exercicio2
    {

            public static void Executar()
            {
                Console.WriteLine("=== QUANTIDADE DE VOGAIS ===");

                Console.Write("Digite uma frase: ");
                string texto = Console.ReadLine();

                int quantidade = 0;

                for (int i = 0; i < texto.Length; i++)
                {
                    char letra = char.ToLower(texto[i]);

                    if (letra == 'a' ||
                        letra == 'e' ||
                        letra == 'i' ||
                        letra == 'o' ||
                        letra == 'u')
                    {
                        quantidade++;
                    }
                }

                Console.WriteLine("Quantidade de vogais: " + quantidade);
            }
        }


    }

