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
        private int pos = 0;

        public int Pos { get { return pos; }  }

        public Fita()
        {
            valores = new ArrayList();
        }

        public String getFita()
        {
            String retorno = "";
            String asterisco = " * ", branco = " _ ", inicial=" > ", auxiliar = " A ";
      
            foreach (Simbolos i in Valores)
            {

                // se ja tiver encontrado o segundo inicial
                if (i.ToString() == "INICIAL")
                {
                    retorno += inicial;
                    continue;
                }
                if (i.ToString() == "ASTERISCO")
                {
                    retorno += asterisco;
                    continue;
                }
                if (i.ToString() == "BRANCO")
                {
                    retorno += branco;
                    continue;
                }
                if (i.ToString() == "AUXILIAR")
                {
                    retorno += auxiliar;
                    continue;
                }
            }
            return retorno;
        }

    }
}
