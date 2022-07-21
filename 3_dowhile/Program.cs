
public class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Quantos programadores precisam de café?");
        int programadores = Convert.ToInt32(Console.ReadLine());

        int cafesPreparados = 0;

        do
        {
            cafesPreparados++;
            Console.WriteLine($"Preparando o {cafesPreparados}° café");
        } while (cafesPreparados < programadores);

        if (cafesPreparados > programadores)
        {
            Console.WriteLine($"Oh não! O café está esfriando e nenhum programador está por perto!");
        }
        else
        {
            Console.WriteLine($"Total de programadores felizes: {cafesPreparados}");
        }

    }
}