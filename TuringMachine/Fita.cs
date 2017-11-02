using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    class Fita
    {
        private ArrayList valores;
        public ArrayList Valores { get { return valores; } set { valores = value; } }

        public Fita()
        {
            valores = new ArrayList();
        }
    }
}
