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
        public void reponer1(decimal cantidadareponerdeagua)
        {
            cantidadmaxima=antidadareponerdeagua+niveldeagua;
            if (cantidadareponerdeagua > 0 && cantidadmaxima < 10000);  //Tama�o del dep�sito de pienso es de 1000 l.
            niveldeagua=niveldeagua+cantidadareponerdeagua;
              



        }
        public void reponer2(decimal cantidadareponerdepienso)
        {

            cantidadmaxima2=cantidadareponerdepienso+niveldepienso;
            if (cantidadareponerdepienso > 0 && cantidadmaxima2 < 5000)  //Tama�o del dep�sito de pienso es de 5000 kg. 
            niveldepienso=niveldepienso+cantidadareponerdepienso;        }


        public decimal consumo1(decimal cantidadaretirardeagua)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= niveldeagua)
            {   retirado1=cantidadaretirardeagua;
            niveldeagua=niveldeagua-cantidadaretirardeagua;}

            return retirado1;
        }
        public decimal consumo2(decimal cantidadaretirardepienso)
        {
            decimal retirado2=0; //Cantidad que se retira
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= niveldepienso)
            {   retirado2=cantidadaretirardepienso;
                niveldepienso=niveldepienso-cantidadaretirardepienso;}
            return retirado2;
        }
    }
}
