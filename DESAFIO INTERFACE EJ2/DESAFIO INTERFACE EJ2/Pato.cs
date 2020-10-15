using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_INTERFACE_EJ2
{
    class Pato:Animal,Volador
    {
        public void volador()
        {
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
        }
    }
}
