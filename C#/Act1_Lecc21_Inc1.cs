internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba un numero del 1 al 7");
        int d = Convert.ToInt32(Console.ReadLine());
        if (d == 1)
            Console.WriteLine("Hoy es Lunes");
        if (d == 2) 
            Console.WriteLine("Hoy es Martes");
        if(d == 3)
            Console.WriteLine("Hoy es Miercoles");
        if (d == 4)
            Console.WriteLine("Hoy es Jueves");
        if (d == 5)
            Console.WriteLine("Hoy es Viernes");
        if (d == 6)
            Console.WriteLine("Hoy es Sabado");
        if (d == 7)
            Console.WriteLine("Hoy es Domingo");
        if (d != 1 && d != 2 && d != 3 && d != 4 && d != 5 && d != 6 && d != 7)
            Console.WriteLine("No existe ese dia de la semana");
    }
}