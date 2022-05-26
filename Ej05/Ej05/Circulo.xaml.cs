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
    public partial class Circulo : ContentPage
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (this.txtRadio.Text.Trim() != "")
            {
                double radio = Convert.ToDouble(txtRadio.Text);
                double area = Math.Pow(radio, 2);
                DisplayAlert("Mensaje","El área del círculo es: " + area.ToString(), "Aceptar");
            }
        }
    }
}