using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_INTERFACE_EJ2
{
    class Superman:Superheroe,Volador
    {
        public void volador()
        {
            Console.WriteLine("“Estoy volando como un campeón...”");
        }
    }
}
