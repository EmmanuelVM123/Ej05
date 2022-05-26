using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ej05
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cuadrado());
        }

        private void btnRectangulo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Rectangulo());
        }

        private void btnTriangulo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Triangulo());
        }

        private void btnCirculo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Circulo());
        }
    }
}
