internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Determine los lados del triangulo");
        int L1 = Convert.ToInt32(Console.ReadLine());
        int L2 = Convert.ToInt32(Console.ReadLine());
        int L3 = Convert.ToInt32(Console.ReadLine());

        if (L1 == L2 && L1 == L3 )
            Console.WriteLine("Es un triangulo Equilatero");
        if (L1 == L2 && L2 != L3 || L1 == L3 && L1 != L2 || L2 == L3 && L1 != L3)
            Console.WriteLine("Es un triangulo Isoceles");
        if (L1 != L2 && L2 != L3 )
            Console.WriteLine("Es un triangulo Escaleno");
    }
}