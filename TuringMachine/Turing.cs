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
            lista.Add(new Table(Estados._0, Simbolos.INICIAL, Estados._0, Simbolos.INICIAL, Direcao.DIREITA));       // 0 e >, [0,>,D] - 0 e inicial, vai para o estado 0, escreve -> e vai para Direita
            lista.Add(new Table(Estados._0, Simbolos.ASTERISCO, Estados._1, Simbolos.BRANCO, Direcao.DIREITA));      // 0 e *, [1,_,D] 
            lista.Add(new Table(Estados._0, Simbolos.BRANCO, Estados._8, Simbolos.BRANCO, Direcao.DIREITA));         // 0 e B, [8,_,D] 
            lista.Add(new Table(Estados._1, Simbolos.ASTERISCO, Estados._1, Simbolos.ASTERISCO, Direcao.DIREITA));   // 1 e *, [1,*,D] 
            lista.Add(new Table(Estados._1, Simbolos.BRANCO, Estados._2, Simbolos.BRANCO, Direcao.DIREITA));         // 1 e B, [2,_,D] 
            lista.Add(new Table(Estados._2, Simbolos.ASTERISCO, Estados._3, Simbolos.AUXILIAR, Direcao.DIREITA));    // 2 e *, [3,A,D] 
            lista.Add(new Table(Estados._2, Simbolos.BRANCO, Estados._6, Simbolos.BRANCO, Direcao.ESQUERDA));        // 2 e B, [6,_,E] 
            lista.Add(new Table(Estados._3, Simbolos.ASTERISCO, Estados._3, Simbolos.ASTERISCO, Direcao.DIREITA));   // 3 e *, [3,*,D] 
            lista.Add(new Table(Estados._3, Simbolos.BRANCO, Estados._4, Simbolos.BRANCO, Direcao.DIREITA));         // 3 e B, [4,_,D] 
            lista.Add(new Table(Estados._4, Simbolos.ASTERISCO, Estados._4, Simbolos.ASTERISCO, Direcao.DIREITA));   // 4 e *, [4,*,D] 
            lista.Add(new Table(Estados._4, Simbolos.BRANCO, Estados._5, Simbolos.ASTERISCO, Direcao.ESQUERDA));     // 4 e B, [5,*,E] 
            lista.Add(new Table(Estados._5, Simbolos.ASTERISCO, Estados._5, Simbolos.ASTERISCO, Direcao.ESQUERDA));  // 5 e *, [5,*,E] 
            lista.Add(new Table(Estados._5, Simbolos.BRANCO, Estados._5, Simbolos.BRANCO, Direcao.ESQUERDA));        // 5 e B, [5,_,E] 
            lista.Add(new Table(Estados._5, Simbolos.AUXILIAR, Estados._2, Simbolos.AUXILIAR, Direcao.DIREITA));     // 5 e A, [2,A,D] 
            lista.Add(new Table(Estados._6, Simbolos.BRANCO, Estados._7, Simbolos.BRANCO, Direcao.ESQUERDA));        // 6 e B, [7,_,E] 
            lista.Add(new Table(Estados._6, Simbolos.AUXILIAR, Estados._6, Simbolos.ASTERISCO, Direcao.ESQUERDA));   // 6 e A, [6,*,E] 
            lista.Add(new Table(Estados._7, Simbolos.ASTERISCO, Estados._7, Simbolos.ASTERISCO, Direcao.ESQUERDA));  // 7 e *, [7,*,E] 
            lista.Add(new Table(Estados._7, Simbolos.BRANCO, Estados._0, Simbolos.BRANCO, Direcao.DIREITA));         // 7 e B, [0,_,D] 
            lista.Add(new Table(Estados._8, Simbolos.ASTERISCO, Estados._8, Simbolos.BRANCO, Direcao.DIREITA));      // 8 e *, [8,_,D] 
            lista.Add(new Table(Estados._8, Simbolos.BRANCO, Estados._9, Simbolos.INICIAL, Direcao.DIREITA));        // 8 e B, [9,>,D] 
            lista.Add(new Table(Estados._9, Simbolos.ASTERISCO, Estados._10, Simbolos.ASTERISCO, Direcao.ESQUERDA)); // 9 e *, [10,*,E] -- Começa a multiplicação aqui, quando vai para o 10


        }
        

    }
}
