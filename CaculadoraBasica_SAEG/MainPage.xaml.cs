using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CaculadoraBasica_SAEG.Funciones;

namespace CaculadoraBasica_SAEG
{
    public partial class MainPage : ContentPage
    {
        string resultado = "";
        string variableAuxiliar = "";
        string conversion = "";
        bool comprobar = false;
        public MainPage()
        {
            InitializeComponent();
        }
        public void Resultados()
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                Resultado.Text = resultado;
            }
            else
            {
                Resultado.Text = resultado + " " + variableAuxiliar;
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            resultado = "";
            variableAuxiliar = "";
            Resultados();
        }
        private void Button_Clicked_Borrar(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_0(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "0";
            }
            else
            {
                variableAuxiliar += "0";
            }
            Resultados();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "1";
            }
            else
            {
                variableAuxiliar += "1";
            }
            Resultados();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false) 
            { 
                resultado += "2";
            }
            else
            {
                variableAuxiliar += "2";
            }
            Resultados();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "3";
            }
            else
            {
                variableAuxiliar += "3";
            }
            Resultados();
        }
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "4";
            }
            else
            {
                variableAuxiliar += "4";
            }
            Resultados();
        }
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "5";
            }
            else
            {
                variableAuxiliar += "5";
            }
            Resultados();
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "6";
            }
            else
            {
                variableAuxiliar += "6";
            }
            Resultados();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "7";
            }
            else
            {
                variableAuxiliar += "7";
            }
            Resultados();
        }
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "8";
            }
            else
            {
                variableAuxiliar += "8";
            }
            Resultados();
        }
        private void Button_Clicked_9(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += "9";
            }
            else
            {
                variableAuxiliar += "9";
            }
            Resultados();
        }
        private void Button_Point(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                comprobar = funcionalidades.EsDecimal(resultado);
                if (comprobar == false)
                {
                    resultado += ".";
                }
            }
            else
            {
                comprobar = funcionalidades.EsDecimal(variableAuxiliar);
                if (comprobar == false)
                {
                    variableAuxiliar += ".";
                }
            }
            Resultados();
        }
        private void Button_Clicked_Resultado(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            if(variableAuxiliar.Length > 0)
            {
                conversion = resultado + variableAuxiliar;
                if (funcionalidades.EsDecimal(resultado) 
                    || funcionalidades.EsDecimal(variableAuxiliar)
                    || funcionalidades.EsDivision(conversion))
                {
                    float operacionHecha = Convert.ToSingle(conversion);
                    resultado = operacionHecha.ToString();
                    variableAuxiliar = "";
                    Resultados();
                }
                else 
                {
                    int operacionesHechas = Convert.ToInt32(conversion);
                    resultado = operacionesHechas.ToString();
                    variableAuxiliar = "";
                    Resultados();
                }
            }
        }
        private void Button_Clicked_Mod(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += " %";
                Resultados();
            }
        }
        private void Button_Clicked_Multi(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += " *";
                Resultados();
            }
        }
        private void Button_Clicked_Suma(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += " +";
                Resultados();
            }
        }
        private void Button_Clicked_Resta(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += " -";
                Resultados();
            }
        }
        private void Button_Clicked_Division(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            comprobar = funcionalidades.TieneOperadores(resultado);
            if (comprobar == false)
            {
                resultado += " /";
                Resultados();
            }
        }
    }
}
