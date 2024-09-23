using System;

namespace ex009{
    public class Program{
        public static void Main(string[] args){
            int idade;

            Console.Write(" - Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            int meses = idade*12;
            int dias = idade*365;

            Console.WriteLine($" - Sua idade em meses é: {meses}");
            Console.WriteLine($" - Sua idade em dias é: {dias}");
        }
    }
}