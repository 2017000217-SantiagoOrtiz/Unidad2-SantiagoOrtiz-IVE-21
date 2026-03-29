internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Detremine su edad");
        Console.WriteLine("Deme su edad:");
        double edad = Convert.ToInt32(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine("Es Mayor de edad");
        }
        else
        {
            Console.WriteLine("Es Menor de edad");
        }

    }
}