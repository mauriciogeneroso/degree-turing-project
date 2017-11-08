using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            fita.Valores.Add(Simbolos.INICIAL);
            for (int i = 0; i < baseTriangulo; i++)
            {
                fita.Valores.Add(Simbolos.ASTERISCO);
            }
            fita.Valores.Add(Simbolos.BRANCO);
            for (int i = 0; i < altura; i++)
            {
                fita.Valores.Add(Simbolos.ASTERISCO);
            }
        }

        public void executar(FormPrincipal form)
        {
            int posicaoAtual = 0;
            
            Simbolos simboloLido;
            Direcao irParaDirecao = Direcao.DIREITA;
            registradorEstado.EstadoAtual = Estados._0;
            while (registradorEstado.EstadoAtual != Estados._FINAL)
            {
                String fitaImprimir = "";
                simboloLido = this.LeFita(posicaoAtual);

                foreach(TabelaItens tbItens in tabelaDeAcao.Tabela)
                {
                    if (tbItens.Estado == registradorEstado.EstadoAtual && tbItens.Simbolo == simboloLido)
                    {
                        registradorEstado.EstadoAtual = tbItens.VaiParaEstado;
                        fita.Valores[posicaoAtual] = tbItens.EscreveSimbolo;
                        irParaDirecao = tbItens.Direcao;
                        break;
                    }
                }

                
                if (irParaDirecao == Direcao.DIREITA)
                {
                    if (posicaoAtual == fita.Valores.Count - 1)
                    {
                        fita.Valores.Add(Simbolos.BRANCO);
                    }
                    posicaoAtual++;
                } else
                {
                    posicaoAtual--;
                }
                for(int i = -1; i < posicaoAtual; i++)
                {
                    fitaImprimir += "   ";
                    if (fita.Valores[posicaoAtual].Equals(Simbolos.AUXILIAR))
                    {
                        fitaImprimir += " ";
                    }
                }
                fitaImprimir += " |";
                form.UpdateAtualPub(fita.getFita());
                form.UpdatePosPub(fitaImprimir);
                
                System.Threading.Thread.Sleep(500);
            }

            
            Console.WriteLine(fita.Valores);
        }

        private Simbolos LeFita(int posicao) => (Simbolos)fita.Valores[posicao];

    }
}
