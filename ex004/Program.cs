namespace ex004{
    public class Program{
        public static void Main(string[] args){
            double grau_celsius;

            Console.Write(" - Informe a temperatura em graus Celsius (°C): ");
            grau_celsius = Convert.ToDouble(Console.ReadLine());

            double grau_fahrenheit = (9 * grau_celsius / 5) + 32;
            Console.WriteLine($" - {grau_celsius}°C equivale a {grau_fahrenheit:f2}°F");
        }
    }
}