using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricaTelefonicaWPF
{
    public class Contatto
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string NumeroTelefonico { get; set; }

        public Contatto() { }

        public Contatto(string nome, string cognome, string numeroTelefonico)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.NumeroTelefonico = numeroTelefonico;
        }
      
    }
}
