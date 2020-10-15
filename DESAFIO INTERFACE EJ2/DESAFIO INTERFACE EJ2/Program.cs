using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_INTERFACE_EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl t1 = new TorreDeControl();
           
            int opc;

            Pato pato = new Pato();
            Superman superman = new Superman();
            Boing747 boing747 = new Boing747();

            do
            {


                Console.WriteLine("Seleccione que  volador desea agregar a la lista: ");
                Console.WriteLine("1: Pato");
                Console.WriteLine("2: Boing747");
                Console.WriteLine("3: Superman");
                Console.WriteLine("4: Mostrar voladores");
                Console.WriteLine("5: Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        t1.agregarVolador(pato);
                        break;
                    case 2:
                        Console.Clear();
                        t1.agregarVolador(boing747);
                        break;
                    case 3:
                        Console.Clear();
                        t1.agregarVolador(superman);
                        break;
                    case 4:
                        Console.Clear();
                        t1.VuelenTodos();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Error! usted a seleccionado una opcion incorrecta.");
                        break;
                }
            } while (opc != 5);

        }
    }
}
