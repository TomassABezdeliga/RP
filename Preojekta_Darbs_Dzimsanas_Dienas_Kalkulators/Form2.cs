using System;
using System.IO;
using System.Windows.Forms;

namespace Preojekta_Darbs_Dzimsanas_Dienas_Kalkulators
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            int i = 0;
        private void butDati_Click(object sender, EventArgs e)
        {
            string[] v = new string[i];
            string[] u = new string[i];
            string[] d = new string[i];
            v[i] = textV.Text;
            u[i] = textU.Text;
            d[i] = textD.Text;
            i++;
            string file = "Personas.txt";
            if (File.Exists(file)==true)
            {
                File.AppendText(v[i]+" "+u[i]+" "+d[i]);
            }
            else
            {
                File.WriteAllText(file, v[i] + " " + u[i] + " " + d[i]);
            }
        }

        private void butBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 sakums = new Form1();
            sakums.Show();
        }

    }
}
