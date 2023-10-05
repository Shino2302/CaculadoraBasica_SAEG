using System;
using System.Collections.Generic;
using System.Text;

namespace CaculadoraBasica_SAEG.Funciones
{
    class Funcionalidades
    {
        public bool EsDecimal(string resultado)
        {
            bool respuesta = false;
            for(int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] != '.')
                {
                    respuesta = false;
                }
                else
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        public bool EsDouble(string resultado) 
        {

        }
    }
}
