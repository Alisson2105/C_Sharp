namespace ex005{
    public class Program{
        public static void Main(string[] args){
            double milhas;

            Console.Write(" - Informe o valor em milhas (mi): ");
            milhas = Convert.ToDouble(Console.ReadLine());

            double km = 1.60934 * milhas;
            Console.WriteLine($" - {milhas} mi equivale a {km:F3} Km");
        }
    }
}