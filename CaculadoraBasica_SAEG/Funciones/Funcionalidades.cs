using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
        public bool TieneOperadores(string resultado) 
        {
            bool respuesta = false;
            for(int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] != '+')
                {
                    respuesta = false;
                }
                else if (resultado[i] != '-')
                {
                    respuesta = false;
                }
                else if (resultado[i] != '*')
                {
                    respuesta = false;
                }
                else if (resultado[i] != '/')
                {
                    respuesta = false;
                }
                else if (resultado[i] != '%')
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
        public bool EsDivision(string conversion)
        {
            bool respuesta = false;
            for(int i = 0; i < conversion.Length; i++)
            {
                if (conversion[i] != '/')
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
    }
}
