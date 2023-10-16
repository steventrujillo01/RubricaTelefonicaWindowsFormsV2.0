using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RubricaTelefonicaWPF
{
    public partial class AggiungiContatto : Form
    {
        public new Form1 Menu = new Form1();

        // Evento per notificare che si ha aggiunto un nuovo contatto.
        public event Action<Contatto> ContattoAggiunto;
     

        public AggiungiContatto()
        {
            InitializeComponent();

        }

  
        private void ButtonSalva_Click(object sender, EventArgs e)
        {
           
            Contatto nuovoContatto = new Contatto
            {
                Nome = Nome.Text,
                Cognome = Cognome.Text,
                NumeroTelefonico = Numero.Text
            };

            if (Menu.Rubrica == null)
            {
                Menu.Rubrica = new List<Contatto>(); // Inizializza la lista se è null
            }
         
            Menu.Rubrica.Add(nuovoContatto);
            // Notificare a Form1 che si ha aggiunto un nuovo contatto
            ContattoAggiunto?.Invoke(nuovoContatto);
            Menu.AggiornaDataGridView();
          
            // Chiudi il form
            this.Close();

        }
    }
}
