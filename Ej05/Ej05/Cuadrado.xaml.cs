using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ej05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cuadrado : ContentPage
    {
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (this.txtLado.Text.Trim() != "")
            {
                double lado = Convert.ToDouble(txtLado.Text);
                double area = lado * lado;
                DisplayAlert("Mensaje", "El área del cuadrado es: " + area.ToString(), "Aceptar");
            }
        }
    }
}