using System;

namespace ex007{
    public class Program{
        public static void Main(string[] args){
            double km;

            try{
                Console.Write(" - Informe um valor em km: ");
                km = Convert.ToDouble(Console.ReadLine());

                double m = km * 1000;
                double cm = km *100000;

                Console.WriteLine($" - {km}km equivale a {m}m (metros).");
                Console.WriteLine($" - {km}km equivale a {cm}cm (centímetros).");
            }
            catch{
                Console.WriteLine(" - Por Favor, insira um número válido.");
            }
        }
    }
}