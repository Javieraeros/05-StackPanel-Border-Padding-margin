using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grid_Formulario.Models
{
    class Persona
    {
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private DateTimeOffset fechaNac { get; set; }

        public Persona(){
            nombre = "";
            apellidos = "";
            fechaNac = new DateTimeOffset();
            }
    }
}
