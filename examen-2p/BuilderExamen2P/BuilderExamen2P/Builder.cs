using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    interface Builder
    {
        //En esta interface estamos colocando las acciones que van a llevar a cabo en cada uno de estos métodos del Constructor como tal.

        //Ejemplo de una Computadora de Escritorio

        // A travéz del Director se va llevar a cabo la iplementación de dicha Computadora


        void ConstrulleCpu();
        void ConstrulleMonitor();
        void ConstrulleTeclado();
        void ConstrulleMouse();

    }
}
