using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    class Constructor: Builder
    {
        //Aqui estamos creando las intancias de nuetro producto que tiene como nombre "COMPUTADORA"
        
        private Producto Computadora = new Producto();
        public void ConstrulleCpu()
        {
            //Este metodo crea una nueva instancia, ya sea que selecionemos Cual tipo de elementos.

            Computadora.InsertarCpu(new CpuGamaMedia());
        }
        public void ConstrulleMonitor()
        {
            Computadora.InsertarMonitor(new Monitor_Resolucion_Media());
        }
        public void ConstrulleTeclado()
        {
            Computadora.InsertarTeclado(new Teclado_Basico());
        }
        public void ConstrulleMouse()
        {
            Computadora.InsertarMouse(new Mouse_Inalambrico());
        }

        //Este metodo es sumamente importante, porque este nos va a permitir sacar el productor que hemos construido por el Builder
        
        public Producto ObtenerProductor()
        {
            return Computadora;
        }
    }
}
