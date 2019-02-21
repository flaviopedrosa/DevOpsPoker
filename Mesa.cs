using System;

namespace Devops
{
   
    public class Mesa{
        public Mesa( Mao maoEsquerda, Mao maoDireita)
        {
            this._maoDireita = maoDireita;
            this._maoEsquerda = maoEsquerda;
        }

        private Mao _maoEsquerda;
        private Mao _maoDireita;

        //Regras
        //Carta Alta: A carta de maior valor.
        //Um Par: Duas cartas do mesmo valor.
        //Dois Pares: Dois pares diferentes.
        //Trinca: Três cartas do mesmo valor e duas de valores diferentes.
        //Straight (sequência): Todas as cartas com valores consecutivos.
        //Flush: Todas as cartas do mesmo naipe.
        //Full House: Uma trinca e um par.
        //Quadra: Quatro cartas do mesmo valor.
        //Straight Flush: Todas as cartas são consecutivas e do mesmo naipe.
        //Royal Flush: A seqüência 10, Valete, Dama, Rei, Ás, do mesmo naipe.
    }    
    
   
}