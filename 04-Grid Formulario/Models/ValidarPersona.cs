using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grid_Formulario.Models
{
    class ValidarPersona
    {
        /// <summary>
        /// Método que comprueba si lso campos de una persona son correctos.
        /// El nombre debe de contener más de dos caracteres.
        /// Deben haber dos apellidos mínimos separados por un espacio
        /// La fecha de nacimiento debe ser anterior al día local.
        /// </summary>
        /// <param name="p">La persona que vamos a validar</param>
        /// <returns>Un array con las cadenas de errores, caso de haberlos
        ///     En el primer hueco del array guardaremos todo lo relacionado con lso nombres
        ///     En el segundo hueco del array guardaremos los posibles errores de los apellidos
        ///     En el tercer y último hueco del array guardaremos los errores de la fecha de nacimiento
        ///     </returns>
        public string[] validaPersona(Persona p)
        {
            DateTimeOffset hoy = DateTimeOffset.Now;
            string[] resultado= {"","",""};
            if (string.IsNullOrEmpty(p.Nombre) || p.Nombre.Length<2)
            {
                resultado[0] = "Error, el nombre debe contener al menos dos letras";
            }else
            {
                if (p.Nombre.ToCharArray()[0]==' ')
                {
                    resultado[0] = "Error, la primera letra no puede ser un espacio";
                }
            }

            if (string.IsNullOrEmpty(p.Apellidos) || p.Apellidos.Length <= 4)
            {
                resultado[1] = "Error, los apellidos deben tener al menos 5 letras";
            }else
            {
                if(!p.Apellidos.Contains(" "))
                {
                    resultado[1] = "Error, debe poner dos apellidos separados por un espacio";
                }
            }

            if(p.FechaNac>hoy)
            {
                resultado[2] = "Error, la fecha de nacimiento debe ser anterior o igual a hoy mismo";
            }

            return resultado;
        }
        /// <summary>
        /// Método que valida los atributos de una persona, del mismo modo que el método anterior
        /// </summary>
        /// <param name="p">La persona que queremos validar</param>
        /// <param name="errores">
        /// Entero donde guardaremos el código de errores
        /// Usaremos un código muy similar al usado en linux:
        /// Errores\Valor | 4 | 2 | 1 |
        /// Nombre        |   |   | X |
        /// Apellidos     |   | X |   |
        /// Fecha Nac     | X |   |   |
        /// Así, para un errore de Apellidos y fecha de nacimiento el valor será 7, y para 
        /// ningún error 0.
        /// </param>
        /// <returns></returns>
        public string[] validaPersona(Persona p,int errores)
        {
            DateTimeOffset hoy = DateTimeOffset.Now;
            string[] resultado = { "", "", "" };
            errores = 0;
            if (string.IsNullOrEmpty(p.Nombre) || p.Nombre.Length < 2)
            {
                resultado[0] = "Error, el nombre debe contener al menos dos letras";
                errores = 1;
            }
            else
            {
                if (p.Nombre.ToCharArray()[0] == ' ')
                {
                    resultado[0] = "Error, la primera letra no puede ser un espacio";
                    errores = 1;
                }
            }

            if (string.IsNullOrEmpty(p.Apellidos) || p.Apellidos.Length <= 4)
            {
                resultado[1] = "Error, los apellidos deben tener al menos 5 letras";
                errores = errores + 2;
            }
            else
            {
                if (!p.Apellidos.Contains(" "))
                {
                    resultado[1] = "Error, debe poner dos apellidos separados por un espacio";
                    errores = errores + 2;
                }
            }

            if (p.FechaNac > hoy)
            {
                resultado[2] = "Error, la fecha de nacimiento debe ser anterior o igual a hoy mismo";
                errores = errores + 4;
            }
            return resultado;
        }
    }
}
