using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mapsForm = new Form1();
            mapsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            casesForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Equipments equipmentsForm = new Equipments();
            equipmentsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tests testsForm = new Tests();
            testsForm.Show();
        }
    }
}
