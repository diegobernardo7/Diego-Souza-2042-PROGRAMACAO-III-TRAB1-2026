using System;
using System.Collections.Generic;
using System.Text;

namespace trabalho1_Tri
{
    internal class Exercicio7
    {

 
            public string Nome { get; set; }
            public string RA { get; set; }
            public double NotaProva { get; set; }
            public double NotaTrabalho { get; set; }
            public double Frequencia { get; set; }

            public double CalcularMedia()
            {
                double media = (NotaProva * 0.7) + (NotaTrabalho * 0.3);

                return media;
            }

            public bool VerificarFaltas()
            {
                double limiteFaltas = 40 * 0.40;

                double faltas = 40 - (40 * Frequencia / 100);

                if (faltas <= limiteFaltas)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Executar()
            {
                Console.WriteLine("=== CADASTRO DE ALUNO ===");

                Console.Write("Nome: ");
                Nome = Console.ReadLine();

                Console.Write("R.A.: ");
                RA = Console.ReadLine();

                Console.Write("Nota da prova: ");
                NotaProva = double.Parse(Console.ReadLine());

                Console.Write("Nota do trabalho: ");
                NotaTrabalho = double.Parse(Console.ReadLine());

                Console.Write("Frequência (%): ");
                Frequencia = double.Parse(Console.ReadLine());

                double media = CalcularMedia();

                Console.WriteLine("\n=== DADOS DO ALUNO ===");
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("R.A.: " + RA);
                Console.WriteLine("Nota da prova: " + NotaProva);
                Console.WriteLine("Nota do trabalho: " + NotaTrabalho);
                Console.WriteLine("Frequência: " + Frequencia + "%");
                Console.WriteLine("Média: " + media.ToString("F2"));

                if (media >= 7 && VerificarFaltas())
                {
                    Console.WriteLine("Resultado: APROVADO");
                }
                else
                {
                    Console.WriteLine("Resultado: REPROVADO");
                }
            }
        }



    }

