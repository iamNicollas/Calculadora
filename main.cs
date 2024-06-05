using System;
class Program
{
    public static void Main(string[] args)
    {

        int valorA;
        int valorB;
        int resultado;

        Console.WriteLine("Para calcular digite o valores A e B.\n");
        Console.WriteLine("Digite o valor de A:");
        valorA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite o valor de B:");
        valorB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEscolha o tipo de operação matemática que deseja realizar:");
        Console.WriteLine(" A- Somar \n B- Subtrair \n C- Multiplicar \n D- Dividir \n");


        switch (Console.ReadLine())
        {
            case "A":
                resultado = valorA + valorB;
                Console.WriteLine("\nO resultado é: " + resultado);
                break;

            case "B":
                resultado = valorA - valorB;
                Console.WriteLine("\nO resultado é: " + resultado);
                break;

            case "C":
                resultado = valorA * valorB;
                Console.WriteLine("O resultado é: " + resultado);
                break;

            case "D":
                resultado = valorA / valorB;
                Console.WriteLine("\nO resultado é: " + resultado);
                break;
        }

        Console.Write("\n Pressione para fechar.");
        Console.ReadKey();
    }
}