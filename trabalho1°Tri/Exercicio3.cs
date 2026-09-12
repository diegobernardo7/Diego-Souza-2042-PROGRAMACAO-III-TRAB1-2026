using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho1_Tri
{
    internal class Exercicio3
    {

            public static void Executar()
            {
                Console.WriteLine("=== APENAS AS VOGAIS ===");

                Console.Write("Digite uma frase: ");
                string texto = Console.ReadLine();

                Console.Write("Vogais: ");

                for (int i = 0; i < texto.Length; i++)
                {
                    char letra = char.ToLower(texto[i]);

                    if (letra == 'a' ||
                        letra == 'e' ||
                        letra == 'i' ||
                        letra == 'o' ||
                        letra == 'u')
                    {
                        Console.Write(letra);
                    }
                }

                Console.WriteLine();
            }
        }


    }

