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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            this.Height = 370;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Width = 1290;
            this.Height = 770;
            pictureBox4.Visible = false;
            pictureBox2.Visible = true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
            TopMost = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mapa_ni_Tiquia aForm = new Mapa_ni_Tiquia();
            aForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Equipments equipmentsForm = new Equipments();
            equipmentsForm.Show();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
