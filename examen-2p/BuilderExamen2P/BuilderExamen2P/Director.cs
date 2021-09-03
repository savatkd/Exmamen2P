using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    class Director
    {
        //este metodo está recibiendo como parametro algo que se está construyendo.
        // en otras palabras está reciendo como parametro un constructor en particular
        public void Construye(Builder pConstructor)
        {

            //Cada unos de estos métodos tan siendo implementado en la clase Constructor

            pConstructor.ConstrulleCpu();
            pConstructor.ConstrulleMonitor();
            pConstructor.ConstrulleTeclado();
            pConstructor.ConstrulleMouse();
        }
    }
}
