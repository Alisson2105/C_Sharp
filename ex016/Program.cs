using System;

namespace ex016
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            bool continuar = true;
            string opcao;

            while (continuar)
            {
                try
                {
                    Console.Write(" - Informe um número e veja se ele é PAR ou ÍMPAR: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine($" - O número {num1} é PAR!");
                    }
                    else
                    {
                        Console.WriteLine($" - O número {num1} é ÍMPAR!");
                    }

                    // Perguntar se deseja continuar
                    do{
                        Console.Write(" - Deseja continuar (s/n)? ");
                        opcao = Console.ReadLine().ToLower();

                        if (opcao == "n"){
                            continuar = false; // Sair do loop principal
                        }else if (opcao != "s" && opcao != "n"){
                            Console.WriteLine("Por favor, escolha 's' para sim ou 'n' para não.");
                        }

                    } while (opcao != "s" && opcao != "n"); // Repetir até obter uma resposta válida

                }
                catch (FormatException)
                {
                    Console.WriteLine(" - Por favor, informe um número válido!");
                }
            }

            Console.WriteLine("Programa Finalizado!");
        }
    }
}