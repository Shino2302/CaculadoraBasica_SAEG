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
            if (!TieneDivision(resultado))
                if (!TieneMod(resultado))
                    if (!TieneMultiplicacion(resultado))
                        if (!TieneResta(resultado))
                            if (!TieneSuma(resultado))
                                respuesta = false;
            else
                respuesta = true;
            return respuesta;
           
        }
        public bool TieneDivision(string conversion)
        {
            bool respuesta = false;
            if (conversion == "")
            {
                respuesta = false;
            }
            else if (conversion[conversion.Length-1] != '/')
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public bool TieneMultiplicacion(string conversion)
        {
            bool respuesta = false;
            if (conversion == "")
            {
                respuesta = false;
            }
            else if (conversion[conversion.Length-1] != '*')
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public bool TieneSuma(string conversion)
        {
            bool respuesta = false;
            if (conversion == "")
            {
                respuesta = false;
            }
            else if (conversion[conversion.Length - 1] != '+')
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public bool TieneResta(string conversion)
        {
            bool respuesta = false;
            if (conversion == "")
            {
                respuesta = false;
            }
            else if (conversion[conversion.Length - 1] != '-')
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public bool TieneMod(string conversion)
        {
            bool respuesta = false;
            if (conversion == "")
            {
                respuesta = false;
            }
            else if (conversion[conversion.Length - 1] != '%')
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public float Resultados(char? operador, float numero1, float numero2)
        {
            switch (operador)
            {
                case '+':
                    return numero1+numero2;
                case '-':
                    return numero1-numero2;
                case '*':
                    return numero1 * numero2;
                case '/':
                    return numero1 / numero2;
                case '%':
                    return numero1 % numero2;
                default:
                    return 0;
            }
        }
    }
}
