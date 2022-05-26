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
    public partial class Rectangulo : ContentPage
    {
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (this.txtBase.Text.Trim() != "" && this.txtAltura.Text.Trim() != "")
            {
                double bas = Convert.ToDouble(this.txtBase.Text.Trim());
                double alt = Convert.ToDouble(this.txtAltura.Text.Trim());
                double area = bas * alt;
                DisplayAlert("Mensaje", "El área del rectángulo es: " + area.ToString(), "Aceptar");
            }
        }
    }
}