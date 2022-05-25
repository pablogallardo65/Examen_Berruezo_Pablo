using System;

namespace Deposito
{
   class Deposito
    {
        private decimal niveldeagua;
        private decimal niveldepienso;
        private decimal Cant_Max_Agua;      //La cantidad m�xima a reponer no puede superar el tama�o del DEP�SITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal Cant_Max_Pienso;     //La cantidad m�xima a reponer no puede superar el tama�o del DEP�SITO DE PIENSO, se comprueba antes de actualizar los niveles. 
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
            Cant_Max_Agua=antidadareponereagua+niveldeagua;
            if (cantidadareponerdeagua > 0 && Cant_Max_Agua < 10000);  //Tama�o del dep�sito de pienso es de 1000 l.
            niveldeagua=niveldeagua+cantidadareponerdeagua;
              



        }
        public void reponer2(decimal cantidadareponerdepienso)
        {

            Cant_Max_Pienso=cantidadareponerdepienso+niveldepienso;
            if (cantidadareponerdepienso > 0 && Cant_Max_Pienso < 5000)  //Tama�o del dep�sito de pienso es de 5000 kg. 
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
