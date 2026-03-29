internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su usuario y su contraseña");
        string u = Console.ReadLine();
        string c = Console.ReadLine();
        if (c == "Pasword123")
        {
            Console.WriteLine("Bienvenido");
        }
        else
        {
            Console.WriteLine("No se le permite el ingreso");
        }
    }
}