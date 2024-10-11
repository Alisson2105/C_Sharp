namespace ex0015{
    public class Program{
        public static void Main(string[] args){
            int num;
            bool condicao = false;
            while(!condicao){
                try{
                    Console.Write(" - Informe um número positivo ou negativo: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if(num > 0){
                        Console.WriteLine($" - O número {num} é positivo.");
                        condicao = true;
                    }else if(num < 0){
                            Console.WriteLine($" - O número {num} é negativo.");
                            condicao = true;
                    }else{
                        Console.WriteLine(" - O número é zero.");
                        condicao = true;
                    }
                }catch(FormatException){
                    Console.WriteLine(" - Por favor, digite um valor válido.");
                }catch(OverflowException){
                    Console.WriteLine(" - Por favor, digite um valor entre -2.147.483.648 e 2.147.483.647.");
                }
            }
        }
    }
}