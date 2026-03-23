internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("PROMEDIO DE NOTAS");
        int n1, n2, n3, n4, n5;
        string materia;
        Console.WriteLine("Dijite la MAteria");
        materia = Console.ReadLine();
        Console.WriteLine("Dijite 5 notas:");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());

        double promedio = (n1 + n2 + n3 + n4 + n5) / 5;
        Console.WriteLine("La materia: " + materia);
        Console.WriteLine("El Promedio es de:" + promedio);
        if (promedio >= 70)
            Console.WriteLine("Estudiante Aprobado");
        else Console.WriteLine("Estudiante Reprobado");
    }
}