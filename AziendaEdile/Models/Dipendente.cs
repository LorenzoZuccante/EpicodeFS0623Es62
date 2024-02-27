﻿namespace AziendaEdile.Models
{
    public class Dipendente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Indirizzo { get; set; }

        public string CodiceFiscale { get; set; }

        public bool Coniugato { get; set; }
        
        public int NumeroDiFigli {  get; set; }
        
        public string Mansione { get; set; }


    }
}