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
    public partial class Triangulo : ContentPage
    {
        public Triangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            

        }

        private void btnCalcular_Clicked_1(object sender, EventArgs e)
        {
            if (this.txtBase.Text.Trim() != "" && this.txtAltura.Text.Trim() != "")
            {
                double bas = Convert.ToDouble(this.txtBase.Text.Trim());
                double alt = Convert.ToDouble(this.txtAltura.Text.Trim());
                double area = (bas * alt) / 2;
                DisplayAlert("Mensaje", "El área del triángulo es: " + area.ToString(), "Aceptar");
            }
        }
    }
}