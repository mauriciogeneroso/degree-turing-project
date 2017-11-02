using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    class Turing
    {
        private ArrayList lista = new ArrayList();

        public Turing ()
        {
            lista.Add(new Table(MaquinaDeTuring.Estados._0, MaquinaDeTuring.Simbolos.INICIAL, MaquinaDeTuring.Direcao.DIREITA));


        }
        

    }
}
