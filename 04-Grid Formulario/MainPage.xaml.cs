using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _04_Grid_Formulario
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool error;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnValidar_Click(object sender, RoutedEventArgs e)
        {
            error = false;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errNombre.Text = "Error, el nombre no puede estar vació";
                error = true;
            }
            else
            {
                if (txtNombre.Text == "Pene")
                {
                    errNombre.Text = "No seas guarro";
                    error = true;
                }
                else
                {
                    errNombre.Text = "";
                }
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errApellido.Text = "Error, el nombre no puede estar vacío";
                error = true;
            }
            else
            {
                errApellido.Text = "";
            }
            if (string.IsNullOrEmpty(txtFechaNacimiento.Text))
            {
                errFecha.Text = "Error, la fecha no puede estar vacía";
                error = true;
            }
            else{
                char[] fecha = txtFechaNacimiento.Text.ToCharArray();
                string sDia,sMes,sAnyo;
                int dia, mes, anyo;
                DateTime thisDay = DateTime.Today;

                sDia = string.Concat(fecha[0],fecha[1]);
                sMes = string.Concat(fecha[3],fecha[4]);
                sAnyo = string.Concat(fecha[6],fecha[7],fecha[8],fecha[9]);
                
                dia = int.Parse(sDia);
                mes = int.Parse(sMes);
                anyo = int.Parse(sAnyo);

                if (anyo < 1582 || (anyo == 1582 && mes < 10 || mes == 10 && dia < 15) ||
                   mes < 1 || mes > 12 || dia < 1 || dia > 31 ||
                   (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) ||
                   (dia > 29 && mes == 2) ||
                   (dia > 28 && mes == 2 && !(anyo % 4 == 0 && (anyo % 100 != 0 || anyo % 400 == 0))) ||
                   anyo >thisDay.Year ||
                   anyo==thisDay.Year && (mes>thisDay.Month || mes==thisDay.Month && dia>thisDay.Day))
                {
                    errFecha.Text = "Error, introduzca una fecha válida";
                    error = true;
                }
                else
                {
                    errFecha.Text = "";
                }

                if (!error)
                {
                    ValidaciónCorrecta.Text="TODO CORRECTO WEEEEEEEE";
                }
            }
        }
    }
}
