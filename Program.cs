internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Numeros Negativos y Positivos");
        int num;
        Console.WriteLine("Ingrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine("El numero es positivo");
        }
        else
        {
                Console.WriteLine("El numero es negativo");

        }
    }
}