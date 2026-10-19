using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MicroNations
{
    public partial class Form1 : Form
    {
        private string filePath = "partite.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSqCasa.Text) || string.IsNullOrWhiteSpace(txtSqOspiti.Text) ||
                string.IsNullOrWhiteSpace(txtGoalCasa.Text) || string.IsNullOrWhiteSpace(txtGoalOspiti.Text))
            {
                MessageBox.Show("Compilare tutti i campi prima di salvare");
                return;
            }
            if (!int.TryParse(txtGoalCasa.Text, out int goalCasa) || goalCasa < 0)
            {
                MessageBox.Show("Inserire un numero valido e non negativo per i goal della squadra di casa");
                return;
            }

            if (!int.TryParse(txtGoalOspiti.Text, out int goalOspiti) || goalOspiti < 0)
            {
                MessageBox.Show("Inserire un numero valido e non negativo per i goal della squadra ospite");
                return;
            }

            Partita nuovaPartita = new Partita(txtSqCasa.Text.Trim(), txtSqOspiti.Text.Trim(), goalCasa, goalOspiti);

            // carica i dati se il file esiste gia
            List<Partita> listaPartite = new List<Partita>();

            listaPartite.Add(nuovaPartita);
            string jsonString = JsonSerializer.Serialize(listaPartite);

            File.WriteAllText(filePath, jsonString);

            MessageBox.Show("Partita salvata con successo");

            PulisciCampi();
        }
            private void PulisciCampi() {

            txtSqCasa.Clear();
            txtSqOspiti.Clear();
            txtGoalCasa.Clear();
            txtGoalOspiti.Clear();
            txtSqCasa.Focus();

        }
    }
}