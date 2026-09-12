namespace trabalho1_Tri
{
    internal class Program
    {

        
            static void Main(string[] args)
            {
                int opcao = 0;

                while (opcao != 8)
                {
                    Console.Clear();

                    Console.WriteLine("=================================");
                    Console.WriteLine("       MENU DE EXERCÍCIOS");
                    Console.WriteLine("=================================");
                    Console.WriteLine("1 - Calculadora");
                    Console.WriteLine("2 - Quantidade de vogais");
                    Console.WriteLine("3 - Imprimir vogais");
                    Console.WriteLine("4 - Imprimir consoantes");
                    Console.WriteLine("5 - Faixa etária");
                    Console.WriteLine("6 - Cadastro de livro");
                    Console.WriteLine("7 - Cadastro de aluno");
                    Console.WriteLine("8 - Sair");
                    Console.WriteLine("=================================");

                    Console.Write("Escolha uma opção: ");
                    opcao = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (opcao)
                    {
                        case 1:
                            Exercicio1.Executar();
                            break;

                        case 2:
                        Exercicio2.Executar();
                            break;

                        case 3:
                            Exercicio3.Executar();
                            break;

                        case 4:
                            Exercicio4.Executar();
                            break;

                        case 5:
                            Exercicio5.Executar();
                            break;

                        case 6:
                            Exercicio6.Executar();
                            break;

                        case 7:
                            Exercicio7 aluno = new Exercicio7();
                            aluno.Executar();
                            break;

                        case 8:
                            Console.WriteLine("Programa encerrado.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    if (opcao != 8)
                    {
                        Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                        Console.ReadLine();
                    }
                }
            }
        }
    }

