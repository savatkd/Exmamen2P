using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExamen2P
{
    interface ITeclado
    {
        string Categorias();
    }
    class Teclado_Basico : ITeclado
    {
        public string Categorias()
        {
            return "Teclado Básico";
        }
    }
    class Teclado_Profesional : ITeclado
    {
        public string Categorias()
        {
            return "Tecaldo Profesional";
        }
    }
}
