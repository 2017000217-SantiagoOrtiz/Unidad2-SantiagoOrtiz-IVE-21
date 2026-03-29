internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("INtroduce un numero");
        int num = 0;
        num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("El numero es menor a cero");
        }
        else
        {
            Console.WriteLine("EL numero es igual o mayor que cero");
        }
    }
}