using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_INTERFACe
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora i1 = new Impresora();

            Documento documento = new Documento();
            Foto foto = new Foto();
            Contrato contrato = new Contrato();
            int opc;

            do
            {
                
                Console.WriteLine("Seleccion que archivo desea agregar a la lista de imprimir");
                Console.WriteLine("1: Documento");
                Console.WriteLine("2: Foto");
                Console.WriteLine("3: Contrato");
                Console.WriteLine("4: Mostrar archivos");
                Console.WriteLine("5: Salir");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        i1.AgregarImprimible(documento);
                        break;
                    case 2:
                        Console.Clear();
                        i1.AgregarImprimible(foto);
                        break;
                    case 3:
                        Console.Clear();
                        i1.AgregarImprimible(contrato);
                        break;
                    case 4:
                        Console.Clear();
                        i1.ImprimirTodo();
                        break;
                    default:
                        Console.WriteLine("ERROR!, opcion incorrecta");
                        break;
                }
            } while (opc != 5);
      
         
        }
    }
}
