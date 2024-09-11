using System;

namespace Ex003{
    public class Program{
        public static void Main(string[] args){
            double peso;
            double peso_total = 0;
            int controle;


            for(controle = 0; controle < 5; controle ++){
                Console.Write($" - Informe o peso da {controle + 1}ª pessoa: ");
                peso = Convert.ToDouble(Console.ReadLine());
                peso_total += peso;
            }
            Console.WriteLine($"A média de peso entre as 5 pessoas é: {(peso_total / 5).ToString("F2")}Kg");
        }
    }
}