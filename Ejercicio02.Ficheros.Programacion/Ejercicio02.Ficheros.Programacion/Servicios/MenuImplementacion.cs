using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Ficheros.Programacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {

            Console.WriteLine("----------------------------");
            Console.WriteLine("| [0] -> CERRAR APLICACION |");
            Console.WriteLine("| [1] -> ALTA ADEUDO SEPA  |");
            Console.WriteLine("----------------------------");

            int seleccionMenu = Convert.ToInt32(Console.ReadLine());
            return seleccionMenu;

        }
    }
}
