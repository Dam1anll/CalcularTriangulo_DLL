using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularTriangulo_DLL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var baseT = double.Parse(Base.Text);
            var altura = double.Parse(Altura.Text);
            var lado1 = double.Parse(Lado1.Text);
            var lado2 = double.Parse(Lado2.Text);
            var area = (baseT * altura) / 2;
            Area.Text = area.ToString();

            string resultado = "";

            if (baseT <= 0 || lado1 <= 0 || lado2 <= 0)
            {
                resultado = "No es un triangulo";
                imgEquilatero.IsVisible = false;
                imgIsoceles.IsVisible = false;
                imgEscaleno.IsVisible = false;
            }

            else if (lado1 == baseT && lado2 == baseT && lado1 == lado2)
            {

                resultado = "Es un triangulo equilatero";
                imgEquilatero.IsVisible = true;
                imgIsoceles.IsVisible = false;
                imgEscaleno.IsVisible = false;

            }

            else if (lado1 != baseT && lado2 != baseT && lado1 != lado2)
            {

                resultado = "Es un triangulo escaleno";
                imgEscaleno.IsVisible = true;
                imgEquilatero.IsVisible = false;
                imgIsoceles.IsVisible = false;
            }

            else
            {

                resultado = "Es un triangulo isoceles";
                imgIsoceles.IsVisible = true;
                imgEscaleno.IsVisible = false;
                imgEquilatero.IsVisible = false;
            }

            DisplayAlert("Resultado", resultado, "Ok");
        }
    }
}
