using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    interface ICpu
    {
        //Método "Característica" que nos regresa una cadena. 
        // Tabién estamos definiendo las clases concretas.
        string Caracteristica();
    }
    //Clases Concretas que herenciada el Interface "ICpu"
    public class CpuGamaMedia : ICpu
    {

        //Aquí estamos implentando el método "Característica" que nos retorna una cadema con un sms.
        public string Caracteristica()
        {
            return ": Cpu Gama Media, Con Procesador Intel Core i7";
        }

        //Clases Concretas
        public class CpuGamaAlta : ICpu
        {
            public string Caracteristica()
            {
                return ": Cpu de Gama Alta, Con Procesador Intel Core i9";
            }
        }
    }
}
