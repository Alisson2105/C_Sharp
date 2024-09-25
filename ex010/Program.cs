namespace ex010{
    public class Program{
        public static void Main(string[] args){
            int A;
            int B;

            try{
                Console.Write(" - Informe um valor inteiro para a variável A:");
                A = Convert.ToInt32(Console.ReadLine());

                Console.Write(" - Informe um valor inteiro para a variável B:");
                B = Convert.ToInt32(Console.ReadLine());

                // int antes_troca_A = A;
                // int depois_troca_A = B;
                // int antes_troca_B = B;
                // int depois_troca_B = A;

                // Console.WriteLine($" - A variável A possuia o valor {antes_troca_A} e agora possui o valor {depois_troca_A}.\n - A variável B possuia o valor {antes_troca_B} e agora possui o valor {depois_troca_B}.");

                int temp = A;
                A = B;
                B = temp;

                Console.WriteLine($" - A variável A possuía o valor {temp} e agora possui o valor {A}.");
                Console.WriteLine($" - A variável B possuía o valor {A} e agora possui o valor {B}.");

            }catch(FormatException){
                Console.WriteLine(" - Por favor, digite um valor válido!");
            }catch(Exception ex){
                Console.WriteLine(" - Por favor, digite um valor válido!");
            }
        }
    }
}