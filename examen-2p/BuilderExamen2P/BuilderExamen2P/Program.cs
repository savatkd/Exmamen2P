using System;

namespace BuilderExamen2P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t**********************Patrón de Diseño Builder Pattern************************" +
                                "\n\t\t                Universidad Laica Eloy Alfaro de Manabí" +
                                "\n\t\t                     Tecnologia de la Información" +
                                " \n\n\t\t                             F a c c i");


            Director MiDirector = new Director();

            //Costruimos la Computadora
            //instanciamos nuestro constructor
            Constructor Pc = new Constructor();
            MiDirector.Construye(Pc);

            // Obtenemos el Producto
            Producto Computadora = Pc.ObtenerProductor();

            Computadora.mostrarComputadora();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nAsí es como Obtenemos el Computador de Esctritorio");
        }
    }
}
