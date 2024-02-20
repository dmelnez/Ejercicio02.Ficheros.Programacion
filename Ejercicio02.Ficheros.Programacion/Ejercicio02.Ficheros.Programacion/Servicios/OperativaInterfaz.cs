using Ejercicio02.Ficheros.Programacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Ficheros.Programacion.Servicios
{
    internal interface OperativaInterfaz
    {

        public void altaAdeudoSepa(List<AdeudoSepaDtos> listaAdeudos);


        //private void creacionFichero(int refOrdernDomi, string idAcreedor, string nombreAcre, string direccionAcre, long codPostarAcre, string nombreAdeudor, string apellido1, string apellido2, string direccionAdeudor, long codPostalAdeudor, string numerCuentaIbanAdeudor, string switchBankAdeudor, char tipPago);


    }
}
