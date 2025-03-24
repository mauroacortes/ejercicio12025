using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12025.Entidades
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => _apodo; set => _apodo = value; }


        public override void GetCredencial()
        {


        }
        public override void GetNombreCompleto()
        {

        }
    }
}
