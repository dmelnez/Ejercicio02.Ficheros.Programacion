using Ejercicio02.Ficheros.Programacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Ficheros.Programacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {



        public void altaAdeudoSepa(List<AdeudoSepaDtos> listaAdeudos)
        {

            AdeudoSepaDtos adeudor = new AdeudoSepaDtos();


            adeudor.RefOrdernDomi = idIterativo(listaAdeudos);
            Console.WriteLine("NOMBRE ADEUDOR: ");
            string nombreAdeudor = Console.ReadLine();
   
            adeudor.NombreAdeudor = nombreAdeudor;
            Console.WriteLine(adeudor.NombreAdeudor);

            Console.WriteLine("APELLIDO 01: ");
            string apellido01Adeudor = Console.ReadLine();
            adeudor.Apellido1 = apellido01Adeudor;

            Console.WriteLine("APELLIDO 02: ");
            adeudor.Apellido2 = Console.ReadLine();

            Console.WriteLine("DIRECCION ADEUDOR: ");
            adeudor.DireccionAdeudor = Console.ReadLine();
            Console.WriteLine("CODIGO POSTAL ADEUDOR: ");
            adeudor.CodPostalAdeudor = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("NUMERO CUENTA ISBAN: ");
            adeudor.NumerCuentaIbanAdeudor = Console.ReadLine();
            Console.WriteLine("SWITCH: ");
            adeudor.SwitchBankAdeudor = Console.ReadLine();
            Console.WriteLine("METODO DE PAGO: R - U ");
            adeudor.TipPago = Convert.ToChar(Console.ReadLine());

            // creacionFichero(adeudor.RefOrdernDomi, adeudor.IdAcreedor, adeudor.NombreAcre, adeudor.DireccionAcre, adeudor.CodPostarAcre, adeudor.Apellido1, adeudor.Apellido2, adeudor.DireccionAdeudor, adeudor.CodPostalAdeudor, adeudor.CodPostalAdeudor, adeudor.SwitchBankAdeudor, adeudor.TipPago);

            listaAdeudos.Add(adeudor);
            creacionFichero(nombreAdeudor, listaAdeudos);

           

        }


            private int idIterativo(List<AdeudoSepaDtos> listaAdeudos)
            {

                int id = 0;

                int tamnioLista = listaAdeudos.Count;

                if (listaAdeudos.Count == 0)
                {

                    id = 1;

                }

                else
                {

                    id = listaAdeudos[tamnioLista - 1].RefOrdernDomi + 1;

                }


                return id;

            }


        // private void creacionFichero(int refOrdernDomi, string idAcreedor, string nombreAcre, string direccionAcre, long codPostarAcre, string nombreAdeudor, string apellido1, string apellido2, string direccionAdeudor, long codPostalAdeudor, string numerCuentaIbanAdeudor, string switchBankAdeudor, char tipPago)


        private void creacionFichero(string nombreAdeudor, List<AdeudoSepaDtos> listaAdeudos)
        
            {


            foreach ( var cliente in listaAdeudos)
            {

                if (cliente.NombreAdeudor.Equals(nombreAdeudor) == true)
                {






                    string ruta = cliente.NombreAdeudor + cliente.Apellido1 + ".txt";

                    using (StreamWriter sw = new StreamWriter(ruta))
                    {

                        sw.WriteLine("----------------------------------------------------------------------------------");
                        sw.WriteLine("| REFERENCIA ORDEN DE LA ORDEN DE DOMICIALIZACION: " + cliente.RefOrdernDomi + " |");
                        sw.WriteLine("| Identifcador del Acreedor:  " + cliente.IdAcreedor + "                         |");
                        sw.WriteLine("| Nombre el Acreedor: " + cliente.NombreAcre + "                                 |");
                        sw.WriteLine("| Direccion: " + cliente.DireccionAcre + "                                       |");
                        sw.WriteLine("| Codigo Postal - Poblacion - Provincia/Pais: " + cliente.CodPostarAcre + "      |");
                        sw.WriteLine("|--------------------------------------------------------------------------------|");
                        sw.WriteLine("| Nombre del Deudorer/es/ " + cliente.NombreAdeudor + "                          |");
                        sw.WriteLine("| Direccion del Deudor " + cliente.DireccionAdeudor + "                          |");
                        sw.WriteLine("| Codigo Postal - Poblacion - Provincia/Pais: " + cliente.CodPostalAdeudor + "   |");
                        sw.WriteLine("| Numero de Cuenta - IBAN                                     Swift - BIC        |");
                        sw.WriteLine("|   " + cliente.NumerCuentaIbanAdeudor + cliente.SwitchBankAdeudor + "           |");
                        sw.WriteLine("|                                                                                |");
                        sw.WriteLine("| Fecha - Localidad                         | Tipo de Pago    R[]      U[]       |");
                        sw.WriteLine("|" + DateTime.Now + "                            " +   cliente.TipPago + "       |");
                        sw.WriteLine("|--------------------------------------------------------------------------------|");
                        sw.WriteLine("| Mediante la firma de esta orden de domiciliación, el deudor autoriza (A) al    |");
                        sw.WriteLine("| al acreedor a enviar instrucciones a la al acreedor a enviar instrucciones a   |");
                        sw.WriteLine("| la entidad del deudor para adeudar su cuenta y (B) ) a la entidad para         |");
                        sw.WriteLine("| efectuar los adeudos en su cuenta siguiendo las instrucciones del acreedor.    |");
                        sw.WriteLine("| Como parte de sus derechos, el deudor está legitimado al reembolso por su      |");
                        sw.WriteLine("| entidad  en los términos y condiciones del contrato suscritocon la misma. La   |");
                        sw.WriteLine("| a solicitud de reembolso deberá efectuarse dentro de las ocho semanas que      |");
                        sw.WriteLine("| siguen a la fecha de adeudo en cuenta. Puede obtener información adicional     |");
                        sw.WriteLine("| sobre sus derechos en su entidad financiera.                                   |");
                        sw.WriteLine("|--------------------------------------------------------------------------------|");
                        sw.WriteLine("|                                                                                |");
                        sw.WriteLine("|                                                                                |");
                        sw.WriteLine("| Firma del Deudor                                    ___________________        |");
                        sw.WriteLine("|--------------------------------------------------------------------------------|");







                    }







                }
                else
                {
                    Console.WriteLine("NO encontrado");
                }


            }



            }


        }
    }
