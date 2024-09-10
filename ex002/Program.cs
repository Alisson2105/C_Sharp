using System;

namespace Ex002{
    public class Program{
        public static void Main(string[] args){
            double valor_hora;
            int horas_trabalhadas;

            Console.Write("- Informe o valor da sua hora de trabalho: R$");
            valor_hora = Convert.ToDouble(Console.ReadLine());

            Console.Write("- Informe quantas horas você trabalhou: ");
            horas_trabalhadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"- O valor do seu salário bruto, é de: {(valor_hora * horas_trabalhadas).ToString("C", new System.Globalization.CultureInfo("pt-br"))}"); // Imprime a hora em formato Real do Brasil, exemplo:R$2.013,00
        }
    }
}