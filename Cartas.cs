using System;

namespace Devops
{
   
    public class Mao{
        private Carta[] Cartas {get;set;}
    }    
    
    public class Carta 
    {
        public EnumValor Valor {get; set;}
        public EnumNaipe Naipe {get; set;}

    }

    public enum EnumValor
    {
        Dois, 
        Tres, 
        Quatro, 
        Cinco, 
        Seis, 
        Sete, 
        Oito, 
        Nove, 
        Dez, 
        Valete, 
        Dama, 
        Rei, 
        As
    }

    public enum EnumNaipe
    {  
        D,
        H,
        S,
        C
    }
    
}