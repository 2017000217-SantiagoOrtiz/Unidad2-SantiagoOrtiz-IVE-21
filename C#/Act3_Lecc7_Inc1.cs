internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Estaciones del Año");
        Console.WriteLine("Escriba el dia y el mes");
        Console.WriteLine("Escriba un numero del 1 al 31");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escriba un mes del 1-12");
        int m = Convert.ToInt32(Console.ReadLine());
        if (m == 1 )
            Console.WriteLine("Es Invierno");
        if (m == 2)
            Console.WriteLine("Es Invierno");
        if (m == 12)
            Console.WriteLine("Es Invierno");
        if (m == 3)
            Console.WriteLine("Es Primavera");
        if (m == 4)
            Console.WriteLine("Es Primavera");
        if (m == 5)
            Console.WriteLine("Es Primavera");
        if (m == 6)
            Console.WriteLine("Es Veranno");
        if (m == 7)
            Console.WriteLine("Es Veranno");
        if (m == 8)
            Console.WriteLine("Es Veranno");
        if (m == 9)
            Console.WriteLine("Es Otoño");
        if (m == 10)
            Console.WriteLine("Es Otoño");
        if (m == 11)
            Console.WriteLine("Es Otoño");
        if (m != 1 && m != 2 && m != 3 && m != 4 && m != 5 && m != 6 && m != 7 && m != 8 && m != 9 && m != 10 && m != 11 && m != 12)
            Console.WriteLine("No existen estas estaciones");

        
    }
}