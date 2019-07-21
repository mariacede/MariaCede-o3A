using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaCedeño3A
{
    class Program
    {
        static bool Primo(int numero)
        {
            int div = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    div++;
                }
            }
            return div == 2;
        }


        static void Main(string[] args)
        {
            //Generar una lista con 50 numeros aleatorios.
            List<Int32> listanumero = new List<Int32> { };
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                listanumero.Add(random.Next(2, 100));
            }

            //Mostrar en consola todos los numeros primos
            Console.WriteLine("Numeros Primos");
            var nprimos = from a in listanumero where Primo(a) select a;
            foreach (var item in nprimos)
            {
                Console.WriteLine(item);
            }

            //Mostrar en consola la suma de todos los elementos
            var sumelem = from a in listanumero select a;
            int suma = 0;
            foreach (var item in sumelem)
            {
                suma += Convert.ToInt32(item);
            }
            Console.WriteLine("*****************************************");
            Console.WriteLine("La suma de todos los elementos es de: {0} ", suma);
            Console.WriteLine("*****************************************");

            //Generar una nueva lista con el cuadrado de los numeros

            List<Int32> listacn = new List<Int32> { };
            Random random1 = new Random();
            for (int i = 0; i < 50; i++)
            {
                listacn.Add(random1.Next(3, 40));
            }

            var cuadrados = from cuad in listacn select cuad;
            foreach (var item in cuadrados)
            {
                double res = Math.Pow(item, 2);
                // Console.WriteLine("{0} = {1}", item, res);
            }

            //Generar una nueva lista con los numeros primos
            List<Int32> listaprimos = new List<Int32>();
            Random random2 = new Random();
            for (int i = 0; i < 50; i++)
            {
                listaprimos.Add(random2.Next(2, 47));
                /* foreach (var item in listaprimos)
                 {
                     while (!Primo(item))
                     {
                         listaprimos.Add(random2.Next(2, 47));
                     }
                 }*/
            }

            //Optener el promedio de todos los numeros mayores a 50 
            var promedio = from v in listanumero where v > 50 select v;
            int s = 0, c = 0;
            foreach (var item in promedio)
            {
                s = s + item;
                c++;
            }

            double promed = s / c;

            //Contar la cantidad de numeros pares e impares
            //var contar = from par in listanumero where (par%2==0) select par;
            var contar = from contarn in listanumero select contarn;
            int cpar = 0, cimp = 0;
            foreach (var item in contar)
            {
                if (item % 2 != 0)
                {
                    cpar++;
                }
                else
                {
                    cimp++;
                }
            }

            //Mostrar en consola, el numero y la cantidad de veces que este se encuentra en la lista
            Console.WriteLine("Numeros y veces repetidas");
            var nurepe = from nr in listanumero orderby nr descending select nr;
            foreach (var item in nurepe)
            {
                int cant = 0;
                foreach (var item1 in nurepe)
                {
                    if (item == item1)
                    {
                        cant++;
                    }
                    else
                    {
                        if (cant < 1)
                        {
                            cant++;
                        }
                    }
                }
                Console.WriteLine("{0}, {1}", item, cant);

            }
            Console.WriteLine("*****************************************");


            //Mostrar en consola los elementos de forma descedente
            Console.WriteLine("Elementos de forma descedente");
            var numdesce = from nd in listanumero orderby nd descending select nd;
            foreach (var item in numdesce)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************************");

            //Mostrar en consola los numero unicos 
            Console.WriteLine("Numeros unicos");
            var numunico = from nunic in listanumero select nunic;
            int sunico = 0;
            foreach (var item in numunico)
            {

                int numu = 0;
                foreach (var item1 in nurepe)
                {
                    if (item == item1)
                    {
                        numu++;
                    }
                    else
                    {
                        if (numu < 1)
                        {
                            numu++;
                        }
                    }
                }
                if (numu == 1)
                {
                    //Sumar todos los numeros unicos de la lista
                    sunico = sunico + item;
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("****************************************************");


            List<Cliente> ListaCliente = new List<Cliente>
            {
                new Cliente{Id=1,Nombre="AyLen Delgado"},
                new Cliente{Id=2,Nombre="Marcelo Lopez"},
                new Cliente{Id=3,Nombre="Angela Cedeño"},
                new Cliente{Id=4,Nombre="Mariana Alvia"},
                new Cliente{Id=5,Nombre="Alexander Muñoz"},
                new Cliente{Id=6,Nombre="Arnol Triviño"},
                new Cliente{Id=7,Nombre="Joseph Alvarado"},
                new Cliente{Id=8,Nombre="Carlona Macias"},
                new Cliente{Id=9,Nombre="Evelyn Macias"},
                new Cliente{Id=10,Nombre="Juana Muente"}
            };
            List<Factura> ListaFactura = new List<Factura>
            {
                new Factura{Observacion="Problemas del producto",Fecha=new DateTime(2019,12,11),IdCliente=4 ,Total=250},
                new Factura{Observacion="Devolucion por fallas",Fecha=new DateTime(2019,05,13),IdCliente=2 ,Total=95},
                new Factura{Observacion="Proximo a caducar ",Fecha=new DateTime(2019,07,11),IdCliente=5 ,Total=100},
                new Factura{Observacion="Problemas con la entrega",Fecha=new DateTime(2018,03,29),IdCliente=3, Total=125},
                new Factura{Observacion="Problemas con su envio",Fecha=new DateTime(2019,09,09),IdCliente=4 ,Total=680},
                new Factura{Observacion="Excelente producto",Fecha=new DateTime(2017,07,16),IdCliente=10 ,Total=540},
                new Factura{Observacion="Aumentar pedido",Fecha=new DateTime(2019,10,18),IdCliente=7 ,Total=1000},
                new Factura{Observacion="Devolucion",Fecha=new DateTime(2019,09,08),IdCliente=8 ,Total=975},
                new Factura{Observacion="Proximo a vender",Fecha=new DateTime(2019,09,23),IdCliente=6 ,Total=800},
                new Factura{Observacion="Exelente producto",Fecha=new DateTime(2019,10,30),IdCliente=1 ,Total=900},

            };

            //los clientes ordenados por nombres
            var ordenNombre = from nom in ListaCliente orderby nom.Nombre select nom;
            Console.WriteLine("*** Clientes ordenados por nombre ***");
            foreach (var item in ordenNombre)
            {
                Console.WriteLine(item.Nombre);
            }
            Console.WriteLine("*****************************************");

            //Las ventas ordenadas por fecha
            var ordenFecha = from fecha in ListaFactura orderby fecha.Fecha select fecha;
            Console.WriteLine("*** Ventas ordenadas por fecha ***");
            foreach (var item in ordenFecha)
            {
                Console.WriteLine("{0}, {1}", item.Fecha, item.Total);
            }
            Console.WriteLine("*****************************************");


            //el cliente con mas ventas realizadas

            var clienVenta = (from facvent in ListaFactura
                              join clivent in ListaCliente on facvent.IdCliente equals clivent.Id
                              select facvent.Total).Max();
            var datclienvat = from vt in ListaFactura
                              where clienVenta == vt.Total
                              join obclient in ListaCliente on vt.IdCliente equals obclient.Id
                              select new
                              {
                                  nomClient = obclient.Nombre,
                              };

            Console.WriteLine("*** Cliente con mas ventas realizadas *** ");
            
            foreach (var item in datclienvat)
            {
                Console.WriteLine("{0} ", item.nomClient);
            }
            Console.WriteLine("");
            Console.WriteLine("*****************************************");


            //las ventas realizadas hace menos de 1 año
            var ventmenos = from vt in ListaFactura
                           join obclient in ListaCliente on vt.IdCliente equals obclient.Id
                           orderby vt.Total ascending
                           where vt.Fecha>= new DateTime(2018,07,19)
                           select new
                           {
                               nomClient = obclient.Nombre,
                               fechaven = vt.Fecha,
                               valventa = vt.Total
                           };

            Console.WriteLine("*** Las ventas realizada hace menos de un año *** ");
            Console.WriteLine("");
            foreach (var item in ventmenos)
            {
                Console.WriteLine("{0}, {1}, {2}", item.nomClient, item.fechaven, item.valventa);
            }
            Console.WriteLine("*****************************************");

            //la venta mas antigua
            var ventantigua = (from facvent in ListaFactura select facvent.Fecha).Min();
            var datosventa = from vt in ListaFactura
                             where ventantigua == vt.Fecha
                             join obclient in ListaCliente on vt.IdCliente equals obclient.Id
                             select new
                             {
                                 nomClient = obclient.Nombre,
                                 fechaven = vt.Fecha,
                                 valventa = vt.Total
                             };

            Console.WriteLine("*** La venta mas antigua *** ");
            Console.WriteLine("");
            foreach (var item in datosventa)
            {
                Console.WriteLine("{0}, {1}, {2}", item.nomClient, item.fechaven, item.valventa);
            }
            Console.WriteLine("*****************************************");


            //la ultima venta realizada
            var utlventa = (from facvent in ListaFactura select facvent.Fecha).Max();
            var datventa = from vt in ListaFactura
                           where utlventa == vt.Fecha
                           join obclient in ListaCliente on vt.IdCliente equals obclient.Id
                           select new
                           {
                               nomClient = obclient.Nombre,
                               fechaven = vt.Fecha,
                               valventa = vt.Total
                           };

            Console.WriteLine("*** La ultima venta realizada *** ");
            Console.WriteLine("");
            foreach (var item in datventa)
            {
                Console.WriteLine("{0}, {1}, {2}", item.nomClient, item.fechaven, item.valventa);
            }
            Console.WriteLine("*****************************************");
            //los clientes que tengan una venta cuya observacion comience con Prob
            var observaProb = from obfac in ListaFactura
                              join obclient in ListaCliente on obfac.IdCliente equals obclient.Id
                              where obfac.Observacion.StartsWith("Prob")
                              select new
                              {
                                  nombreCliente = obclient.Nombre,
                                  ventcliente = obfac.Total,
                                  ObservacionFact = obfac.Observacion

                              };
            Console.WriteLine("*** Clientes cuya observacion comience con Prob *** ");
            Console.WriteLine("");
            foreach (var item in observaProb)
            {
                Console.WriteLine("{0}, {1}, {2}", item.nombreCliente, item.ventcliente, item.ObservacionFact);
            }
            Console.WriteLine("");
            Console.WriteLine("*****************************************");



            Console.ReadKey();
        }
        class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        class Factura
        {
            public string Observacion { get; set; }
            public int IdCliente { get; set; }
            public DateTime Fecha { get; set; }
            public int Total { get; set; }
        }
    }
}
