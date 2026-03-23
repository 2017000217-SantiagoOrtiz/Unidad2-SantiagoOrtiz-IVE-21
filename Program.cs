internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MENSAJE DE VOZ");
        int opc;
        Console.Write("Menu principal\n");
        Console.Write("1- Recepcion\n");
        Console.Write("2- Vigilancia\n");
        Console.Write("3- Mantenimiento\n");
        Console.Write("4- Salir\n");
        Console.Write("Digite una opcion []:");
        opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Dep. de Recepcion");
        }
        if (opc == 2)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Dep. de Vigilancia");
        }
        if (opc == 3)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Dep. de Mantenimiento");
        }
        if (opc != 1 && opc != 2 && opc != 3)
        {
            Console.Clear();
            Console.WriteLine("Saliendo del sistema");
        }

    }
}