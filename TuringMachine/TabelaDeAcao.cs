using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    class TabelaDeAcao
    {
        private ArrayList tabela;
        public ArrayList Tabela { get { return tabela; } set { tabela = value; } }

        public TabelaDeAcao ()
        {
            Tabela = new ArrayList
            {
                new TabelaItens(Estados._0, Simbolos.INICIAL, Estados._0, Simbolos.INICIAL, Direcao.DIREITA),       // 0 e >, [0,>,D] - 0 e inicial, vai para o estado 0, escreve -> e vai para Direita
                new TabelaItens(Estados._0, Simbolos.ASTERISCO, Estados._1, Simbolos.BRANCO, Direcao.DIREITA),      // 0 e *, [1,_,D] 
                new TabelaItens(Estados._0, Simbolos.BRANCO, Estados._8, Simbolos.BRANCO, Direcao.DIREITA),         // 0 e B, [8,_,D] 
                new TabelaItens(Estados._1, Simbolos.ASTERISCO, Estados._1, Simbolos.ASTERISCO, Direcao.DIREITA),   // 1 e *, [1,*,D] 
                new TabelaItens(Estados._1, Simbolos.BRANCO, Estados._2, Simbolos.BRANCO, Direcao.DIREITA),         // 1 e B, [2,_,D] 
                new TabelaItens(Estados._2, Simbolos.ASTERISCO, Estados._3, Simbolos.AUXILIAR, Direcao.DIREITA),    // 2 e *, [3,A,D] 
                new TabelaItens(Estados._2, Simbolos.BRANCO, Estados._6, Simbolos.BRANCO, Direcao.ESQUERDA),        // 2 e B, [6,_,E] 
                new TabelaItens(Estados._3, Simbolos.ASTERISCO, Estados._3, Simbolos.ASTERISCO, Direcao.DIREITA),   // 3 e *, [3,*,D] 
                new TabelaItens(Estados._3, Simbolos.BRANCO, Estados._4, Simbolos.BRANCO, Direcao.DIREITA),         // 3 e B, [4,_,D] 
                new TabelaItens(Estados._4, Simbolos.ASTERISCO, Estados._4, Simbolos.ASTERISCO, Direcao.DIREITA),   // 4 e *, [4,*,D] 
                new TabelaItens(Estados._4, Simbolos.BRANCO, Estados._5, Simbolos.ASTERISCO, Direcao.ESQUERDA),     // 4 e B, [5,*,E] 
                new TabelaItens(Estados._5, Simbolos.ASTERISCO, Estados._5, Simbolos.ASTERISCO, Direcao.ESQUERDA),  // 5 e *, [5,*,E] 
                new TabelaItens(Estados._5, Simbolos.BRANCO, Estados._5, Simbolos.BRANCO, Direcao.ESQUERDA),        // 5 e B, [5,_,E] 
                new TabelaItens(Estados._5, Simbolos.AUXILIAR, Estados._2, Simbolos.AUXILIAR, Direcao.DIREITA),     // 5 e A, [2,A,D] 
                new TabelaItens(Estados._6, Simbolos.BRANCO, Estados._7, Simbolos.BRANCO, Direcao.ESQUERDA),        // 6 e B, [7,_,E] 
                new TabelaItens(Estados._6, Simbolos.AUXILIAR, Estados._6, Simbolos.ASTERISCO, Direcao.ESQUERDA),   // 6 e A, [6,*,E] 
                new TabelaItens(Estados._7, Simbolos.ASTERISCO, Estados._7, Simbolos.ASTERISCO, Direcao.ESQUERDA),  // 7 e *, [7,*,E] 
                new TabelaItens(Estados._7, Simbolos.BRANCO, Estados._0, Simbolos.BRANCO, Direcao.DIREITA),         // 7 e B, [0,_,D] 
                new TabelaItens(Estados._8, Simbolos.ASTERISCO, Estados._8, Simbolos.BRANCO, Direcao.DIREITA),      // 8 e *, [8,_,D] 
                new TabelaItens(Estados._8, Simbolos.BRANCO, Estados._9, Simbolos.FINAL, Direcao.DIREITA)           // 8 e B, [FIM] 
                //lista.Add(new Tabela(Estados._8, Simbolos.BRANCO, Estados._9, Simbolos.INICIAL, Direcao.DIREITA));           // 8 e B, [9,>,D]  -- Escreve inicial para começar a divisão
                //lista.Add(new Tabela(Estados._9, Simbolos.ASTERISCO, Estados._10, Simbolos.ASTERISCO, Direcao.ESQUERDA));    // 9 e *, [10,*,E] -- Começa a divisão aqui, quando vai para o estado 10 com >
            };
        }
    }
}
