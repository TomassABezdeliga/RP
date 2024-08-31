using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Preojekta_Darbs_Dzimsanas_Dienas_Kalkulators
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void butBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }
        string file = "Persona.txt";
        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(file) == true)
            {
                string[] lines = File.ReadAllLines(file);
                comBox.Items.Add(lines);
            }
            else
            {
                MessageBox.Show("Nav nevienas personas dati ievadīti!");
            }
        }

        private void butRez_Click(object sender, EventArgs e)
        {
            
            string rez = labRez.Text;
        }
    }
}
