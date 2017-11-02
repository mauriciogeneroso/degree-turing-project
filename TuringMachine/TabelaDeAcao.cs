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
                new TabelaItens(Estados._0, Simbolos.INICIAL, Estados._0, Simbolos.INICIAL, Direcao.DIREITA),          // 0 e >, [0,>,D] - 0 e inicial, vai para o estado 0, escreve -> e vai para Direita
                new TabelaItens(Estados._0, Simbolos.ASTERISCO, Estados._1, Simbolos.BRANCO, Direcao.DIREITA),         // 0 e *, [1,_,D] 
                new TabelaItens(Estados._0, Simbolos.BRANCO, Estados._8, Simbolos.BRANCO, Direcao.DIREITA),            // 0 e B, [8,_,D] 
                new TabelaItens(Estados._1, Simbolos.ASTERISCO, Estados._1, Simbolos.ASTERISCO, Direcao.DIREITA),      // 1 e *, [1,*,D] 
                new TabelaItens(Estados._1, Simbolos.BRANCO, Estados._2, Simbolos.BRANCO, Direcao.DIREITA),            // 1 e B, [2,_,D] 
                new TabelaItens(Estados._2, Simbolos.ASTERISCO, Estados._3, Simbolos.AUXILIAR, Direcao.DIREITA),       // 2 e *, [3,A,D] 
                new TabelaItens(Estados._2, Simbolos.BRANCO, Estados._6, Simbolos.BRANCO, Direcao.ESQUERDA),           // 2 e B, [6,_,E] 
                new TabelaItens(Estados._3, Simbolos.ASTERISCO, Estados._3, Simbolos.ASTERISCO, Direcao.DIREITA),      // 3 e *, [3,*,D] 
                new TabelaItens(Estados._3, Simbolos.BRANCO, Estados._4, Simbolos.BRANCO, Direcao.DIREITA),            // 3 e B, [4,_,D] 
                new TabelaItens(Estados._4, Simbolos.ASTERISCO, Estados._4, Simbolos.ASTERISCO, Direcao.DIREITA),      // 4 e *, [4,*,D] 
                new TabelaItens(Estados._4, Simbolos.BRANCO, Estados._5, Simbolos.ASTERISCO, Direcao.ESQUERDA),        // 4 e B, [5,*,E] 
                new TabelaItens(Estados._5, Simbolos.ASTERISCO, Estados._5, Simbolos.ASTERISCO, Direcao.ESQUERDA),     // 5 e *, [5,*,E] 
                new TabelaItens(Estados._5, Simbolos.BRANCO, Estados._5, Simbolos.BRANCO, Direcao.ESQUERDA),           // 5 e B, [5,_,E] 
                new TabelaItens(Estados._5, Simbolos.AUXILIAR, Estados._2, Simbolos.AUXILIAR, Direcao.DIREITA),        // 5 e A, [2,A,D] 
                new TabelaItens(Estados._6, Simbolos.BRANCO, Estados._7, Simbolos.BRANCO, Direcao.ESQUERDA),           // 6 e B, [7,_,E] 
                new TabelaItens(Estados._6, Simbolos.AUXILIAR, Estados._6, Simbolos.ASTERISCO, Direcao.ESQUERDA),      // 6 e A, [6,*,E] 
                new TabelaItens(Estados._7, Simbolos.ASTERISCO, Estados._7, Simbolos.ASTERISCO, Direcao.ESQUERDA),     // 7 e *, [7,*,E] 
                new TabelaItens(Estados._7, Simbolos.BRANCO, Estados._0, Simbolos.BRANCO, Direcao.DIREITA),            // 7 e B, [0,_,D] 
                new TabelaItens(Estados._8, Simbolos.ASTERISCO, Estados._8, Simbolos.BRANCO, Direcao.DIREITA),         // 8 e *, [8,_,D] 
                //new TabelaItens(Estados._8, Simbolos.BRANCO, Estados._FINAL, Simbolos.BRANCO, Direcao.DIREITA),      // 8 e B, [FIM] -- Até aqui faz a multiplicação 

                new TabelaItens(Estados._8, Simbolos.BRANCO, Estados._9, Simbolos.INICIAL, Direcao.DIREITA),           // 8 e B, [9,>,D] -- Início preparação para divisão
                new TabelaItens(Estados._9, Simbolos.ASTERISCO, Estados._9, Simbolos.ASTERISCO, Direcao.DIREITA),      // 9 e *, [9,*,D]
                new TabelaItens(Estados._9, Simbolos.BRANCO, Estados._10, Simbolos.BRANCO, Direcao.DIREITA),           // 9 e B, [10,B,D]
                new TabelaItens(Estados._10, Simbolos.BRANCO, Estados._11, Simbolos.ASTERISCO, Direcao.DIREITA),       // 10 e B, [11,*,D]
                new TabelaItens(Estados._11, Simbolos.BRANCO, Estados._12, Simbolos.ASTERISCO, Direcao.ESQUERDA),      // 11 e B, [12,*,E]
                new TabelaItens(Estados._12, Simbolos.ASTERISCO, Estados._12, Simbolos.ASTERISCO, Direcao.ESQUERDA),   // 12 e *, [12,*,E]
                new TabelaItens(Estados._12, Simbolos.BRANCO, Estados._12, Simbolos.BRANCO, Direcao.ESQUERDA),         // 12 e B, [12,B,E]
                new TabelaItens(Estados._12, Simbolos.INICIAL, Estados._13, Simbolos.INICIAL, Direcao.DIREITA),        // 12 e >, [13,>,D]
                new TabelaItens(Estados._13, Simbolos.ASTERISCO, Estados._14, Simbolos.ASTERISCO, Direcao.ESQUERDA),   // 13 e *, [14,*,E] -- Fim preparação para divisão

                new TabelaItens(Estados._14, Simbolos.ASTERISCO, Estados._14, Simbolos.ASTERISCO, Direcao.DIREITA),    // 14 e *, [14,*,D] -- Começa a divisão aqui
                new TabelaItens(Estados._14, Simbolos.BRANCO, Estados._15, Simbolos.BRANCO, Direcao.DIREITA),          // 14 e B, [15,_,D]
                new TabelaItens(Estados._14, Simbolos.INICIAL, Estados._14, Simbolos.INICIAL, Direcao.DIREITA),        // 14 e >, [14,>,D]
                new TabelaItens(Estados._15, Simbolos.ASTERISCO, Estados._15, Simbolos.ASTERISCO, Direcao.DIREITA),    // 15 e *, [15,*,D]
                new TabelaItens(Estados._15, Simbolos.BRANCO, Estados._16, Simbolos.BRANCO, Direcao.ESQUERDA),         // 15 e B, [16,_,E]
                new TabelaItens(Estados._15, Simbolos.AUXILIAR, Estados._16, Simbolos.AUXILIAR, Direcao.ESQUERDA),     // 15 e A, [16,A,E]
                new TabelaItens(Estados._16, Simbolos.ASTERISCO, Estados._17, Simbolos.AUXILIAR, Direcao.ESQUERDA),    // 16 e *, [17,A,E]
                new TabelaItens(Estados._16, Simbolos.BRANCO, Estados._20, Simbolos.BRANCO, Direcao.DIREITA),          // 16 e B, [20,_,D]
                new TabelaItens(Estados._16, Simbolos.AUXILIAR, Estados._16, Simbolos.AUXILIAR, Direcao.ESQUERDA),     // 16 e A, [16,A,E]
                new TabelaItens(Estados._17, Simbolos.ASTERISCO, Estados._17, Simbolos.ASTERISCO, Direcao.ESQUERDA),   // 17 e *, [17,*,E]
                new TabelaItens(Estados._17, Simbolos.BRANCO, Estados._18, Simbolos.BRANCO, Direcao.ESQUERDA),         // 17 e B, [18,_,E]
                new TabelaItens(Estados._18, Simbolos.ASTERISCO, Estados._18, Simbolos.ASTERISCO, Direcao.ESQUERDA),   // 18 e *, [18,*,E]
                new TabelaItens(Estados._18, Simbolos.BRANCO, Estados._19, Simbolos.BRANCO, Direcao.DIREITA),          // 18 e B, [19,_,D]
                new TabelaItens(Estados._18, Simbolos.INICIAL, Estados._19, Simbolos.INICIAL, Direcao.DIREITA),        // 18 e >, [19,>,D]
                new TabelaItens(Estados._19, Simbolos.ASTERISCO, Estados._14, Simbolos.BRANCO, Direcao.DIREITA),       // 19 e *, [14,_,D]
                new TabelaItens(Estados._19, Simbolos.BRANCO, Estados._23, Simbolos.BRANCO, Direcao.DIREITA),          // 19 e B, [23,_,D]
                new TabelaItens(Estados._20, Simbolos.BRANCO, Estados._21, Simbolos.BRANCO, Direcao.DIREITA),          // 20 e B, [21,_,D]
                new TabelaItens(Estados._20, Simbolos.AUXILIAR, Estados._20, Simbolos.ASTERISCO, Direcao.DIREITA),     // 20 e A, [20,*,D]
                new TabelaItens(Estados._21, Simbolos.ASTERISCO, Estados._21, Simbolos.ASTERISCO, Direcao.DIREITA),    // 21 e *, [21,*,D]
                new TabelaItens(Estados._21, Simbolos.BRANCO, Estados._22, Simbolos.ASTERISCO, Direcao.ESQUERDA),      // 21 e B, [22,*,E]
                new TabelaItens(Estados._22, Simbolos.ASTERISCO, Estados._22, Simbolos.ASTERISCO, Direcao.ESQUERDA),   // 22 e *, [22,*,E]
                new TabelaItens(Estados._22, Simbolos.BRANCO, Estados._16, Simbolos.BRANCO, Direcao.ESQUERDA),         // 22 e B, [16,_,E]
                new TabelaItens(Estados._23, Simbolos.ASTERISCO, Estados._23, Simbolos.BRANCO, Direcao.DIREITA),       // 23 e *, [23,_,D]
                new TabelaItens(Estados._23, Simbolos.AUXILIAR, Estados._24, Simbolos.BRANCO, Direcao.DIREITA),        // 23 e A, [24,_,D]
                new TabelaItens(Estados._24, Simbolos.ASTERISCO, Estados._FINAL, Simbolos.ASTERISCO, Direcao.DIREITA), // 24 e *, [FIM]
                new TabelaItens(Estados._24, Simbolos.BRANCO, Estados._24, Simbolos.BRANCO, Direcao.DIREITA),          // 24 e B, [24,_,D]
                new TabelaItens(Estados._24, Simbolos.AUXILIAR, Estados._25, Simbolos.BRANCO, Direcao.DIREITA),        // 24 e A, [25,_,D]
                new TabelaItens(Estados._25, Simbolos.BRANCO, Estados._26, Simbolos.BRANCO, Direcao.DIREITA),          // 25 e B, [16,_,D]
                new TabelaItens(Estados._25, Simbolos.AUXILIAR, Estados._25, Simbolos.AUXILIAR, Direcao.DIREITA),      // 25 e A, [25,A,D]
                new TabelaItens(Estados._26, Simbolos.ASTERISCO, Estados._25, Simbolos.ASTERISCO, Direcao.DIREITA),    // 26 e *, [25,*,D]
                new TabelaItens(Estados._26, Simbolos.BRANCO, Estados._27, Simbolos.BRANCO, Direcao.DIREITA),          // 26 e B, [27,_,D]
                new TabelaItens(Estados._27, Simbolos.ASTERISCO, Estados._27, Simbolos.ASTERISCO, Direcao.DIREITA),    // 27 e *, [27,*,D]
                new TabelaItens(Estados._27, Simbolos.BRANCO, Estados._28, Simbolos.ASTERISCO, Direcao.ESQUERDA),      // 27 e B, [28,*,E]
                new TabelaItens(Estados._28, Simbolos.ASTERISCO, Estados._28, Simbolos.ASTERISCO, Direcao.ESQUERDA),   // 28 e *, [28,*,E]
                new TabelaItens(Estados._28, Simbolos.BRANCO, Estados._28, Simbolos.BRANCO, Direcao.ESQUERDA),         // 28 e B, [28,_,E]
                new TabelaItens(Estados._28, Simbolos.AUXILIAR, Estados._15, Simbolos.BRANCO, Direcao.DIREITA),        // 28 e A, [15,_,D]
                new TabelaItens(Estados._28, Simbolos.INICIAL, Estados._FINAL, Simbolos.INICIAL, Direcao.DIREITA),     // 28 e >, [FIM]
            };
        }
    }
}
