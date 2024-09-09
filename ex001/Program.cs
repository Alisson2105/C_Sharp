using System;
using System.Globalization; // Para configurar a cultura

namespace Calculo{
    public class Soma{
        public static void Main(String[] args){
            Double num1;
            Double num2;

            Console.Write("- Informe um número real (exemplo:10,5): ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("- Informe outro número real (exemplo:10,5): ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A soma entre {num1} e {num2} é: {num1 + num2}");

        }
    }
}