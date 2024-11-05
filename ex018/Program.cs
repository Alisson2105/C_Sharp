namespace ex018{
    public class Program{
        public static void Main(string[] args){
            int a, b, c;
            
            Console.Write("- Informe o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("- Informe o valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("- Informe o valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if(a + b > c && a + c > b && b + c > a){
                int Base, Altura;

                Console.WriteLine("- Os três valores informados formam um triângulo!");

                Console.Write("- Infomre a base do triângulo: ");
                Base = Convert.ToInt32(Console.ReadLine());

                Console.Write("- Informe a altura do triângulo: ");
                Altura = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"- A área do triângulo formado com os lados a={a}, b={b} e c={c}, vale {(Base * Altura) / 2}Cm².");
            }else{
                Console.WriteLine($"- Os valores lidos foram: \n- a={a}\n- b={b}\n- c={c}");
            }

        }
    }
}