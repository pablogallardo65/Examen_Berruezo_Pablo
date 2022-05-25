using System;

namespace Deposito
{
   class Deposito
    {
        private decimal niveldeagua;
        private decimal niveldepienso;
        private decimal cantidadmaxima;      //La cantidad m�xima a reponer no puede superar el tama�o del DEP�SITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal cantidadmaxima2;     //La cantidad m�xima a reponer no puede superar el tama�o del DEP�SITO DE PIENSO, se comprueba antes de actualizar los niveles. 
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
            cantidadmaxima=antidadareponerdeagua+niveldeagua;
            if (cantidadareponerdeagua > 0 && cantidadmaxima < 10000);  //Tama�o del dep�sito de pienso es de 1000 l.
            niveldeagua=niveldeagua+cantidadareponerdeagua;

            Cant_Max_Pienso = cantidadareponerdepienso + niveldepienso;
            if (cantidadareponerdepienso > 0 && Cant_Max_Pienso < 5000)  //Tama�o del dep�sito de pienso es de 5000 kg. 
                niveldepienso = niveldepienso + cantidadareponerdepienso;


        }
      

<<<<<<< Updated upstream
            cantidadmaxima2=cantidadareponerdepienso+niveldepienso;
            if (cantidadareponerdepienso > 0 && cantidadmaxima2 < 5000)  //Tama�o del dep�sito de pienso es de 5000 kg. 
            niveldepienso=niveldepienso+cantidadareponerdepienso;        }
=======
>>>>>>> Stashed changes

        public decimal consumo(decimal cantidadaretirardeagua, decimal cantidadaretirardepienso)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= niveldeagua)
            {   retirado1=cantidadaretirardeagua;
            niveldeagua=niveldeagua-cantidadaretirardeagua;}
            if(retirado1 > 0)
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

            else { return 0; };

        }
        
       
    }
}
