namespace ex023{
    public class Program{
        public static void Main(string[] args){

            double nota;
            double soma = 0;
            double media;
            
            int controle;
            for (controle = 0; controle < 3; controle++){

                bool notaValida = false;
                
                // Laço para garantir a inserção de uma nota válida
                while (!notaValida){
                    try{
                        Console.Write($" - Informe a {controle + 1}ª nota do aluno: ");
                        nota = Convert.ToDouble(Console.ReadLine());

                        // Garantir que a nota está dentro de um intervalo válido
                        if (nota < 0 || nota > 10){
                            Console.WriteLine(" - A nota deve estar entre 0 e 10.");
                        }
                        else{
                            soma += nota;
                            notaValida = true; // Nota válida inserida, saindo do laço
                        }
                    }
                    catch{
                        Console.WriteLine(" - Informe uma nota válida.");
                    }
                }
            }

            // Calcula a média
            media = soma / 3;
            Console.WriteLine($" - A média do aluno é {media:F2}.");

            // Exibe o status do aluno com base na média
            if (media >= 7){
                Console.WriteLine(" - Parabéns, você foi APROVADO!");
            }
            else if (media >= 5){
                Console.WriteLine(" - Estude um pouco mais, você está de RECUPERAÇÃO!");
            }
            else{
                Console.WriteLine(" - Infelizmente você foi REPROVADO!");
            }
        }
    }
}