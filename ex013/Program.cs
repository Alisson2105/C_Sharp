using System;

namespace ex013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string genero = string.Empty;
            double peso = 0.0;
            double altura = 0.0;

            bool estado = false;

            // Tratamento do gênero
            while (!estado)
            {
                Console.Write(" - Informe seu sexo (M ou F): ");
                genero = Console.ReadLine();

                if (!string.IsNullOrEmpty(genero))
                {
                    genero = genero.ToUpper(); // Converte a entrada para maiúsculo

                    if (genero == "M")
                    {
                        Console.WriteLine(" - Você escolheu o sexo masculino!");
                        estado = true;
                    }
                    else if (genero == "F")
                    {
                        Console.WriteLine(" - Você escolheu o sexo feminino!");
                        estado = true;
                    }
                    else
                    {
                        Console.WriteLine(" - Por favor, informe uma opção válida (M ou F).");
                    }
                }
                else
                {
                    Console.WriteLine(" - Entrada inválida. Tente novamente.");
                }
            }

            // Entrada e validação de peso
            bool pesoValido = false;
            while (!pesoValido)
            {
                Console.Write(" - Informe seu peso (em kg): ");
                if (double.TryParse(Console.ReadLine(), out peso) && peso > 0)
                {
                    pesoValido = true;
                }
                else
                {
                    Console.WriteLine(" - Por favor, insira um valor válido para o peso.");
                }
            }

            // Entrada e validação de altura
            bool alturaValida = false;
            while (!alturaValida)
            {
                Console.Write(" - Informe sua altura (em metros): ");
                if (double.TryParse(Console.ReadLine(), out altura) && altura > 0)
                {
                    alturaValida = true;
                }
                else
                {
                    Console.WriteLine(" - Por favor, insira um valor válido para a altura.");
                }
            }

            // Cálculo do IMC
            double imc = peso / (altura * altura);

            // Exibe o IMC formatado com 2 casas decimais
            Console.WriteLine($" - Seu Índice de Massa Corporal (IMC) é: {imc:F2}");
        }
    }
}