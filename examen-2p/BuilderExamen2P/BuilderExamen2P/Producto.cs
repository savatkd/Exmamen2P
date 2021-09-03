using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    //Respresenta el Producto que el Builder va a Construir  
    class Producto
    {
        // Variables de Referencia
        //En donde estos objetos Implementa a cada uno de los intefaces que hemos creado.

        private ICpu Cpu;
        private IMonitor Monitor;
        private ITeclado Teclado;
        private IMouse Mouse;


       

        //Instacia directamente del Builder
        //Asignacion de variables interna   
        public void InsertarCpu(ICpu pCpu)
        {
            Cpu = pCpu;
            Console.WriteLine("\n\nSe ah Insertado el Cpu:{0}", Cpu.Caracteristica());
        }
        public void InsertarMonitor(IMonitor pMonitor)
        {
            Monitor = pMonitor;
            Console.WriteLine("Se ah insertado el Monitor:{0}", Monitor.Propiedades());
        }
        public void InsertarTeclado(ITeclado pTeclado)
        {
            Teclado = pTeclado;
            Console.WriteLine("Se ah inseratado el teclado:{0}", Teclado.Categorias());
        }
        public void InsertarMouse(IMouse pMouse)
        {
            Mouse = pMouse;
            Console.WriteLine("Se ah Insertado el Mouse:{0}", Mouse.Particularidad());
        }

        // Este método es simplemente voy mostrar los componentes que le hemos agg a dicha computadora
        // Este método nos muestra cada una de las caracteristica especifica que hemos adisionado a esa computadora
        public void mostrarComputadora()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nEl Computador tiene componente como{0}, {1}, {2}.", Cpu.Caracteristica(),
                               Monitor.Propiedades(), Teclado.Categorias(), Mouse.Particularidad());
        }
    }
}
