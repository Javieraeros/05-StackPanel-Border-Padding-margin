using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grid_Formulario.Models
{
    class Persona
    {

        public string nombre { get; set; }
        public string apellidos { get; set; }
        public DateTimeOffset fechaNac { get; set; }

        public Persona(){
            nombre = "";
            apellidos = "";
            fechaNac = new DateTimeOffset();
            }

        public Persona(string nombre, string apellidos, DateTimeOffset fechaNac)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
        }
    }
}
