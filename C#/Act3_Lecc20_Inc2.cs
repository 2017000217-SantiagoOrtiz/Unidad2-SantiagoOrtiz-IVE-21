internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba la Calificacion del estudiante");
        double n = Convert.ToInt32(Console.ReadLine());
        if (n >= 0 && n < 70)
            Console.WriteLine("El estudiante ha reprobado");
        if (n >= 70 && n == 100)
            Console.WriteLine("EL estudiante ha aprobado");
        if (n > 100)
            Console.WriteLine("No existe esa nota");
    }
}