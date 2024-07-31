namespace SegundoExercicio{
    public class Program{
        public static void Main(string[] args){
            int num1, num2;

            Console.Write(" - Digite um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" - Digite outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" - A soma Entre {num1} e {num2}, é: {num1 + num2}");

            Console.WriteLine(" - Pressione enter para encerrar o programa.");
            Console.ReadLine();
        }
    }
}