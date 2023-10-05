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
        string operaciones = "";
        string variableAuxiliar = "";
        public MainPage()
        {
            InitializeComponent();
        }
        public void Resultados()
        {
            Resultado.Text = resultado;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            resultado = "";
            Resultados();
        }
        private void Button_Clicked_Borrar(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_0(object sender, EventArgs e)
        {
            resultado += "0";
            Resultados();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            resultado += "1";
            Resultados();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            resultado += "2";
            Resultados();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            resultado += "3";
            Resultados();
        }
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            resultado += "4";
            Resultados();
        }
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            resultado += "5";
            Resultados();
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            resultado += "6";
            Resultados();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            resultado += "7";
            Resultados();
        }
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            resultado += "8";
            Resultados();
        }
        private void Button_Clicked_9(object sender, EventArgs e)
        {
            resultado += "9";
            Resultados();
        }
        private void Button_Point(object sender, EventArgs e)
        {
            Funcionalidades funcionalidades = new Funcionalidades();
            if (!funcionalidades.EsDecimal(resultado))
            {
                resultado += ".";
                Resultados();
            }
        }

        private void Button_Clicked_Resultado(object sender, EventArgs e)
        {

        }
        private void Button_Clicked_Mod(object sender, EventArgs e)
        {

        }
    }
}
