int num1, num2;

Console.Write(" - Informe o primeiro número: ");
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine(" - Entrada inválida. Por favor, insira um número inteiro.");
}

Console.Write(" - Informe o segundo número: ");
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine(" - Entrada inválida. Por favor, insira um número inteiro.");
}

string resultado = num1 == num2 ? $" - Os números {num1} e {num2} são iguais." : $" - O maior número é {Math.Max(num1, num2)}.";

Console.WriteLine(resultado);