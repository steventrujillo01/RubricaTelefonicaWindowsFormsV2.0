using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RubricaTelefonicaWPF.Contatto;


namespace RubricaTelefonicaWPF
{
    public partial class Form1 : Form
    {
        private List<Contatto> rubrica = new List<Contatto>();
    
        public Form1()
        {
            InitializeComponent();
            CreaOggetti();

        }

        public List<Contatto> Rubrica
        {
            get { return rubrica; }
            set { rubrica = value; }
        }

        public void CreaOggetti()
        {
            rubrica.Add(new Contatto("Steven", "Trujillo", "2353253200"));
            rubrica.Add(new Contatto("Angello", "Rossi", "2352346571"));
            rubrica.Add(new Contatto("Maria", "Ricci", "2353253233"));
            rubrica.Add(new Contatto("Camilla", "Moretti", "2453532532"));
        }
        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Assicurati che l'evento sia scatenato da una cella nella colonna "modificar"
            if (e.ColumnIndex == dataGridView1.Columns["Modifica"].Index && e.RowIndex >= 0)
            {
                // Ottieni il contatto associato alla riga selezionata
                DataGridViewRow rigaSelezionata = dataGridView1.Rows[e.RowIndex];
                Contatto contattoSelezionato = (Contatto)rigaSelezionata.DataBoundItem;

                // Crea un nuovo form per la modifica e passa il contatto
                FormModificaContatto formModifica = new FormModificaContatto(contattoSelezionato);
                formModifica.ShowDialog();

                // Aggiorna la riga nel DataGridView dopo la modifica
                dataGridView1.Refresh();
            }
            // Aggiungi una condizione per verificare se la colonna "eliminare" è stata cliccata
            else if (e.ColumnIndex == dataGridView1.Columns["Elimina"].Index && e.RowIndex >= 0)
            {
                // Ottieni il contatto associato alla riga selezionata
                DataGridViewRow rigaSelezionata = dataGridView1.Rows[e.RowIndex];
                Contatto contattoSelezionato = (Contatto)rigaSelezionata.DataBoundItem;

                // Elimina il contatto della lista
                rubrica.Remove(contattoSelezionato);


                // Aggiorna la riga nel DataGridView dopo la modifica
                AggiornaDataGridView();
            }
            else
            {
                MessageBox.Show("Nessuna riga selezionata o colonna non valida.");
            }


        }



        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurare il DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rubrica;  // Assegnare lista di contatti come DataSource
          
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            // Aprire AggiungiContatto(form) per aggiungere un nuovo contatto
            AggiungiContatto agg = new AggiungiContatto();
            agg.ContattoAggiunto += AggContatto;  // aggiunge dopo il conto nuovo nella lista
            agg.ShowDialog();



        }

        public void AggContatto(Contatto contatto)
        {
            // Aggiunge il contatto a la lista
            rubrica.Add(contatto);


            // Aggiorna il DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rubrica;
        }


        public void AggiornaDataGridView()
        {
            if (rubrica != null && rubrica.Any())  // Verifica che la lista non sia null e che contenga contatti
            {
                // Imposta la lista come sorgente dati del DataGridView
                dataGridView1.DataSource = null; // Annulla la sorgente dati esistente
                dataGridView1.DataSource = rubrica; // Imposta la nuova sorgente dati
            }
        }
       
        private void Label5_Click(object sender, EventArgs e)
        {

        }
        
        private void Ricerca_button_Click(object sender, EventArgs e)
        {
           
            string termineRicerca = Ricerca.Text.ToLower();  // Converti il termine di ricerca in minuscolo
            List<Contatto> contattiTrovati = rubrica
                    .Where(c => c.Nome.ToLower().Contains(termineRicerca) || c.Cognome.ToLower().Contains(termineRicerca) || c.NumeroTelefonico.Contains(termineRicerca))
                    .ToList();

            // Aggiorna il DataGridView con i risultati della ricerca
            dataGridView1.DataSource = contattiTrovati;

        }
      
    }
}
