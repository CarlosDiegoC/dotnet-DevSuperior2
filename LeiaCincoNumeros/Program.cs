class Program
{
    static void Main(string[] args)
    {
        
        double numero1 = LerNumeros();
        double numero2 = LerNumeros();
        double numero3 = LerNumeros();
        double numero4 = LerNumeros();
        double numero5 = LerNumeros();
        double[] vetorDeNumeros = {numero1, numero2, numero3, numero4, numero5};
        Console.WriteLine("O menor número é: " + vetorDeNumeros.Min());
        Console.WriteLine("O maior número é: " + vetorDeNumeros.Max());
        Console.WriteLine("A média é: " + vetorDeNumeros.Average());

    }

    static double LerNumeros()
    {
        Console.WriteLine("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());
        return numero;
    }


}