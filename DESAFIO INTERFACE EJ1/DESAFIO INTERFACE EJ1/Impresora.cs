using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DESAFIO_INTERFACe
{
    
    public class Impresora
    {
        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }
        public void ImprimirTodo()
        {
            foreach(Imprimible i in ColaDeImpresion)
            {
                i.Imprimir();
            }
        } 
    }
}
