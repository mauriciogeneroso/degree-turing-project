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
        public String getFita()
        {
            String retorno = "";
            String asterisco = " * ", branco = " _ ", inicial = " > ";
            bool flag = false;
            foreach (Simbolos i in Valores)
            {
                if (i.ToString() == "ASTERISCO" && !flag)
                {
                    // se falso, troca true 
                    flag = !flag;
                    retorno += inicial;
                    retorno += asterisco;
                    continue;
                }
                if (!flag)
                {
                    continue;
                }
                // se ja tiver encontrado o segundo inicial
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
            }
            return retorno;
        }
        public Fita()
        {
            valores = new ArrayList();
        }
    }
}
