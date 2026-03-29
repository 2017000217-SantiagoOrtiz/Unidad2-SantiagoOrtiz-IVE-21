internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Meses del Año");
        Console.WriteLine("Escriba el numero que corresponde al mes");
        Console.WriteLine("1 = Enero");
        Console.WriteLine("2 = Febrero");
        Console.WriteLine("3 = Marzo");
        Console.WriteLine("4 = Abril");
        Console.WriteLine("5 = Mayo");
        Console.WriteLine("6 = Junio");
        Console.WriteLine("7 = Julio");
        Console.WriteLine("8 = Agosto");
        Console.WriteLine("9 = Septiembre");
        Console.WriteLine("10 = Octubre");
        Console.WriteLine("11 = Noviembre");
        Console.WriteLine("12 = Diciembre");
        double m = Convert.ToInt32(Console.ReadLine());
        if (m == 1)
            Console.WriteLine("El mes es Enero");
        if (m == 2)
            Console.WriteLine("El mes es Febreo");
        if (m == 3)
            Console.WriteLine("El mes es Marzo");
        if (m == 4)
            Console.WriteLine("El mes es Abril");
        if (m == 5)
            Console.WriteLine("El mes es Mayo");
        if (m == 6)
            Console.WriteLine("El mes es Junio");
        if (m == 7)
            Console.WriteLine("El mes es Julio");
        if (m == 8)
            Console.WriteLine("El mes es Agosto");
        if (m == 9)
            Console.WriteLine("El mes es Septiembre");
        if (m == 10)
            Console.WriteLine("El mes es Octubre");
        if (m == 11)
            Console.WriteLine("El mes es Noviembre");
        if (m == 12)
            Console.WriteLine("El mes es Diciembre");
        if (m != 1 && m != 2 && m != 3 && m != 4 && m != 5 && m != 6 && m != 7 && m != 8 && m != 9 && m != 10 && m != 11 && m != 12)
            Console.WriteLine("No existe ese mes");
    }
}