using _04_Grid_Formulario.Models;
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
            string nombre, apellidos;
            DateTimeOffset fechaNac;
            ValidarPersona VP = new ValidarPersona();
            string[] errores = { "", "", "" };

            nombre = txtNombre.Text;
            apellidos = txtApellido.Text;
            fechaNac = txtFechaNacimiento.Date;
            Persona p = new Persona(nombre, apellidos, fechaNac);

            p.Nombre = txtNombre.Text;      //Sin esto no funciona, no se por qué
            p.Apellidos = txtApellido.Text;
            p.FechaNac = txtFechaNacimiento.Date;

            errores = VP.validaPersona(p);
            errNombre.Text = errores[0];
            errApellido.Text = errores[1];
            errFecha.Text = errores[2];
            if(errores[0]==errores[1] && 
               errores[0] == errores[2]) //Podría haber usado dos comparaciones cualesquiera
            {
                ValidaciónCorrecta.Text = "Todo correcto, puede continuar :)";
            }
        }
    }
}
