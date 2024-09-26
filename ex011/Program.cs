namespace ex011{
    public class Program{
        public static void Main(string[] args){
            int num1;
            int num2;

            Console.Write(" - Informe o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" - Informe o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2){
                Console.WriteLine($" O número {num1} é o maior.");
            }else if(num2 > num1){
                Console.WriteLine($" - O número {num2} é o maior.");
            }else{
                Console.WriteLine($" - Os números {num1} e {num2} são iguais.");
            }
        }
    }
}