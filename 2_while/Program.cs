public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Quantos programadores precisam de café?");
        int programadores = Convert.ToInt32(Console.ReadLine());

        int cafesPreparados = 0;

        while (cafesPreparados < programadores)
        {
            cafesPreparados++;
            Console.WriteLine($"Preparando o {cafesPreparados}° café");
        }

        Console.WriteLine($"Total de programadores felizes: {cafesPreparados}");

    }
}