using System;

namespace ex006{
    public class Program{
        public static void Main(string[] args){
            int duracao_evento;

            Console.Write(" - Informe a duração do evento em seguntos: ");
            duracao_evento = Convert.ToInt32(Console.ReadLine());

            int horas = duracao_evento / 3600;
            int resto_horas = duracao_evento % 3600;
            int minutos = resto_horas / 60;
            int segundos = resto_horas % 60;

            Console.WriteLine($" - O evento tem a duração de {horas:D2}:{minutos:D2}:{segundos:D2}");
        }
    }
}