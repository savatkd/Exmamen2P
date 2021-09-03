using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    class BuilderSpecial: Builder
    {
        private Producto Computadora = new Producto();
        public void InsertarCpu()
        {
            Computadora.InsertarCpu(new CpuGamaMedia());
        }
        public void InsertarMonitor()
        {
            Computadora.InsertarMonitor(new Monitor_Resolucion_Alta());
        }
        public void InsertarTeclado()
        {
            Computadora.InsertarTeclado(new Teclado_Profesional());
        }
        public void InsertarMouse()
        {
            Computadora.InsertarMouse(new Mouse_Inalambrico());
        }
        public Producto ObtenerProducto()
        {
            return Computadora;
        }

        public void ConstrulleCpu()
        {
            throw new NotImplementedException();
        }

        public void ConstrulleMonitor()
        {
            throw new NotImplementedException();
        }

        public void ConstrulleTeclado()
        {
            throw new NotImplementedException();
        }

        public void ConstrulleMouse()
        {
            throw new NotImplementedException();
        }
    }
}
