using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_INTERFACE_EJ2
{
    class TorreDeControl
    {
        List<Volador> voladores = new List<Volador>();
      
        public void agregarVolador(Volador unVolador)
        {
          
            voladores.Add(unVolador);
            
        }
        public void VuelenTodos()
        {
            foreach(Volador i in voladores)
            {
                i.volador();
            }
        }
    }
}
