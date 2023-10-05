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
        char? operador;
        bool comprobar = false;
        public MainPage()
        {
            InitializeComponent();
        }
        public void Resultados()
        {
            if(operador == null)
            {
                Resultado.Text = resultado;
            }
            else
            {
                Resultado.Text = variableAuxiliar;
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

        private void Button_Clicked_Numeros(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (operador == null)
            {
                resultado += button.Text;
            }
            else
            {
                variableAuxiliar += button.Text;   
            }
            Resultados();
        }

        private void Button_Point(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            if (!funcionalidades.TieneOperadores(resultado))
            {
                if (!funcionalidades.EsDecimal(resultado))
                {
                    resultado += ".";
                    Resultados();
                }
            }
            else
            {
                if (!funcionalidades.EsDecimal(variableAuxiliar))
                {
                    variableAuxiliar += ".";
                    Resultados();
                }
            }
        }
        private void Button_Clicked_Resultado(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            float numero1 = Convert.ToSingle(resultado);
            float numero2 = Convert.ToSingle(variableAuxiliar);
            resultado = (funcionalidades.Resultados(operador, numero1, numero2)).ToString();
            variableAuxiliar = "";
            operador = null;
            Resultados();
        }
        private void Button_Clicked_Mod(object sender, EventArgs e)
        {
            operador = '%';
            Resultados();
        }
        private void Button_Clicked_Multi(object sender, EventArgs e)
        {
            operador = '*';
            Resultados();
        }
        private void Button_Clicked_Suma(object sender, EventArgs e)
        {
            operador = '+';
            Resultados();
        }
        private void Button_Clicked_Resta(object sender, EventArgs e)
        {
            operador = '-';
            Resultados();
        }
        private void Button_Clicked_Division(object sender, EventArgs e)
        {
            operador = '/';
            Resultados();
        }
    }
}
