using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_INTERFACe
{
    class Documento:Imprimible 
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un documento word");
        }
    }
}
