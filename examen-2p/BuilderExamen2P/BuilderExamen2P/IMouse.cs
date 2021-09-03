using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    interface IMouse
    {
        string Particularidad();
    }
    class Mouse_Alambrico : IMouse
    {
        public string Particularidad()
        {
            return "Teclado Alambrico";
        }
    }
    class Mouse_Inalambrico : IMouse
    {
        public string Particularidad()
        {
            return "Mouse Inalambrico";
        }
    }
}
