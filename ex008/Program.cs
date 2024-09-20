using System;

namespace ex009{
    public class Program{
        public static void Main(string[] args){
            int num;

           
           try{
                Console.Write(" - Informe um número para a tabuada: ");
                num = Convert.ToInt32(Console.ReadLine());

                for (int controle = 0; controle <= 10; controle++){
                    Console.WriteLine($" - {num} X {controle} = {controle * num}");
                }
            }
            catch (FormatException){
                Console.WriteLine(" - Por Favor, informe um número válido!");
            }
            catch (OverflowException){
                Console.WriteLine(" - O número informado é muito grande!");
            }
            catch (Exception ex){
                Console.WriteLine($" - Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }
}