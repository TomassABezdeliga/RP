using System;
using System.Windows.Forms;

namespace Preojekta_Darbs_Dzimsanas_Dienas_Kalkulators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butJauns_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 jaun_persona = new Form2();
            jaun_persona.Show();
        }

        private void butKalk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 kalkulators = new Form3();
            kalkulators.Show();
        }
    }
}
