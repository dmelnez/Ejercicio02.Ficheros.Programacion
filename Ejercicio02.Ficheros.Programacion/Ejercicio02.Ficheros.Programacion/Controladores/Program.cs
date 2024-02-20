using Ejercicio02.Ficheros.Programacion.Dtos;
using Ejercicio02.Ficheros.Programacion.Servicios;

namespace Ejercicio02.Ficheros.Programacion.Controladores
{
    class Program
    {

        public static void Main(string[] args)
        {
            MenuInterfaz me = new MenuImplementacion();

            OperativaInterfaz op = new OperativaImplementacion();

            List<AdeudoSepaDtos> listaAdeudos = new List<AdeudoSepaDtos>();

            bool cerrarAplicacion = false;

            do
            {

                switch (me.menuPrincipal())
                {
                    case 0:
                        cerrarAplicacion = true;
                    break;

                    case 1:
                        op.altaAdeudoSepa(listaAdeudos);
                    break;

                    default:
                        Console.WriteLine("SELECCION NO VALIDA");
                    break;

                }

            }


            while (!cerrarAplicacion);

    
        }



    }
}