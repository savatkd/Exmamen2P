using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    interface IMonitor
    {
        string Propiedades();
    }

    //Clases Concretas que implementa el Interface "IMonitor"
    class Monitor_Resolucion_Media : IMonitor
    {

        //Implementacion de "Propiedades" que nos retorna un sms.
        public string Propiedades()
        {
            return "Monitor de Resolución Media, con Pantalla 17º Pulgadas";
        }
    }

    //Clases Concretas
    class Monitor_Resolucion_Alta : IMonitor
    {
        public string Propiedades()
        {
            return "Monitor de Alta Resolución de 24º Pulgasas";
        }
    }
}
