using Math;

namespace ex14{
    public class Program{
        public static void Main(string[] args){
            int opcao, num1, num2;
            
            bool cont = false;    
            while(!cont){
                try{
                    Console.Write(" - Informe o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" - Informe o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write(" - Agora, escolha uma das opções abaixo para efetuar o cálculo:\n 1 - Adição (+)\n 2 - Subtração (-)\n 3 - Divisão (/)\n 4 - Multiplicação (*)\n - Número da operação: ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    
                    if(opcao == 1){
                        Console.WriteLine("<<<<<ADIÇÃO>>>>>");
                        Console.WriteLine($" - A soma entre {num1} e {num2} é: {Operacoes.Adicao(num1, num2)}");
                        cont = true;
                    }else if(opcao == 2){
                        Console.WriteLine("<<<<<SUBTRAÇÃO>>>>>");
                        Console.WriteLine($" - A subtração entre {num1} e {num2} é: {Operacoes.Subtracao(num1, num2)}");
                        cont = true;
                    }else if(opcao == 3){
                        Console.WriteLine("<<<<<DIVISÃO>>>>>");
                        Console.WriteLine($" - A divisão entre {num1} e {num2} é: {Operacoes.Divisao(num1, num2)}");
                        cont = true;
                    }else if(opcao == 4){
                        Console.WriteLine("<<<<<MULTIPLICAÇÃO>>>>>");
                        Console.WriteLine($" - A multiplicação entre {num1} e {num2} é: {Operacoes.Multiplicacao(num1, num2)}");
                        cont = true;
                    }
                }catch(FormatException){
                    Console.WriteLine(" - Erro! Por favor, informe um valor válido.");
                }
            }
        }
    }
}