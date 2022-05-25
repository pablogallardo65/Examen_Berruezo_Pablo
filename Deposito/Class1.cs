using System;

namespace Deposito
{
   class Deposito
    {
        private decimal niveldeagua;
        private decimal niveldepienso;
        private decimal Cant_Max_Agua;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal Cant_Max_Pienso;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        public decimal Niveldeagua
        {
            get { return niveldeagua; }
        }
        public decimal Niveldepienso
        {
            get { return niveldepienso; }
        }
        public void reponer(decimal cantidadareponerdeagua , decimal cantidadareponerdepienso)
        {
            Cant_Max_Agua=antidadareponereagua+niveldeagua;
            if (cantidadareponerdeagua > 0 && Cant_Max_Agua < 10000);  //Tamaño del depósito de pienso es de 1000 l.
            niveldeagua=niveldeagua+cantidadareponerdeagua;

            Cant_Max_Pienso = cantidadareponerdepienso + niveldepienso;
            if (cantidadareponerdepienso > 0 && Cant_Max_Pienso < 5000)  //Tamaño del depósito de pienso es de 5000 kg. 
                niveldepienso = niveldepienso + cantidadareponerdepienso;


        }
     
       


        public decimal consumo(decimal cantidadaretirardeagua, decimal cantidadaretirardepienso)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= niveldeagua)
            {   retirado1=cantidadaretirardeagua;
            niveldeagua=niveldeagua-cantidadaretirardeagua;}
            if (retirado1 > 0)
            {
                return retirado1;
            }
           

            decimal retirado2 = 0; //Cantidad que se retira
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= niveldepienso)
            {
                retirado2 = cantidadaretirardepienso;
                niveldepienso = niveldepienso - cantidadaretirardepienso;
            }
            if (retirado2 > 0)
            {
                return retirado2;
            }
            else
            {
                return 0;
            }
        }
       
    }
}
