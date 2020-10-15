using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_INTERFACe
{
    class Contrato:Imprimible
    {
        public void Imprimir()
        {
            Console.WriteLine("Soy un contrato muy legal");
        }
    }
}
