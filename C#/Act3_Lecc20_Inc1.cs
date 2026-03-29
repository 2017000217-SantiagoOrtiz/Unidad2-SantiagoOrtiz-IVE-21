internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero de la semana");
        Console.WriteLine("1 = Lunes");
        Console.WriteLine("2 = Martes");
        Console.WriteLine("3 = Miercoles");
        Console.WriteLine("4 = Jueves");
        Console.WriteLine("5 = Virnes");
        Console.WriteLine("6 = Sabado");
        Console.WriteLine("7 = Domingo");
        double d = Convert.ToInt32(Console.ReadLine());
        if (d == 1 || d == 2 || d == 3 || d == 4 || d == 5)
            Console.WriteLine("Ese dia es entre semana");
        if (d == 6 || d == 7)
            Console.WriteLine("Ese dia es fin de semana");
        if (d != 1 && d != 2 && d != 3 && d != 4 && d != 5 && d != 6 && d != 7)
            Console.WriteLine("Ese dia no existe");
    }
}