internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Buzon de Voz");
        Console.WriteLine(" Escriba un numero");
        Console.WriteLine(" Escriba 1 para Ventas");
        Console.WriteLine(" Escriba 2 para Recepcion");
        Console.WriteLine(" Escriba 3 para Direccion");
        Console.WriteLine(" Escriba 4 para Compras");
        Console.WriteLine(" Escriba 5 para Gerencia");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 1)
            Console.WriteLine("Bienvenido al Departamento de Ventas \n Acargo de: Joaquin Menocal \n jmenocal@gmail.ventas");
        if (n == 2)
            Console.WriteLine("Bienvenido al Departamento de Recepcion \n Acargo de: Jose Portillo \n jportillo@gmail.recp");
        if (n == 3)
            Console.WriteLine("Bienvenido al Departamento de Direccion \n Acargo de: Javier Lobos \n jlobos@gmail.dircc");
        if (n == 4)
            Console.WriteLine("Bienvenido al Departamento de Compras \n Acargo de: Francisco Gil \n fgil@gmail.compras");
        if (n == 5)
            Console.WriteLine("Bienvenido al Departamento de Gerencia \n Acargo de: Diego Chocochic \n dchocochic@gmail.gerencia");
        if (n != 1 && n != 2 && n != 3 && n != 4 && n != 5)
            Console.WriteLine("Este Departamento no se encuentra disponible pruebelo mas tarde");
    }
}