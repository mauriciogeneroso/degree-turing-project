using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    class Cabecote
    {
        private Fita fita;
        private RegistradorDeEstado registradorEstado;
        private TabelaDeAcao tabelaDeAcao;

        public Cabecote(int baseTriangulo, int altura)
        {
            fita = new Fita();
            registradorEstado = new RegistradorDeEstado();
            tabelaDeAcao = new TabelaDeAcao();

            this.criaFita(baseTriangulo, altura);
            
        }

        private void criaFita(int baseTriangulo, int altura)
        {
            String temporaria = ">";

            for(int i = 0; i < baseTriangulo; i++)
            {
                temporaria += "*";
            }
            temporaria += "_";
            for (int i = 0; i < altura; i++)
            {
                temporaria += "*";
            }
            fita.Valor = temporaria;
        }

    }
}
