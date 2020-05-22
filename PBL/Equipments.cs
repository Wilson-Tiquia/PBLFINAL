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
    public partial class Equipments : Form
    {
        public Equipments()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void extend1_Click(object sender, EventArgs e)
        {
            panel16.Visible = true;
            map.Visible = true;
            casess.Visible = true;
            tests.Visible = true;
            pictureBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            extend2.Visible = true;
            extend1.Visible = false;
        }

        private void extend2_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            map.Visible = false;
            casess.Visible = false;
            tests.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            extend2.Visible = false;
            extend1.Visible = true;
        }

        private void map_Click(object sender, EventArgs e)
        {
            Form1 mapForms = new Form1();
            mapForms.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Cases casesForms = new Cases();
            casesForms.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tests testsForms = new Tests();
            testsForms.Show();
        }

        private void extend2_Click_1(object sender, EventArgs e)
        {
            topPanel.Visible = false;
            map.Visible = false;
            casess.Visible = false;
            tests.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            extend2.Visible = false;
            extend1.Visible = true;
        }

        private void extend1_Click_1(object sender, EventArgs e)
        {
            topPanel.Visible = true;
            map.Visible = true;
            casess.Visible = true;
            tests.Visible = true;
            pictureBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            extend2.Visible = true;
            extend1.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Equipments_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            this.Height = 370;
            pictureBox6.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Width = 1290;
            this.Height = 770;
            pictureBox6.Visible = true;
            pictureBox4.Visible = false;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void map_Click_1(object sender, EventArgs e)
        {
            Form1 mapForm = new Form1();
            mapForm.Show();
        }

        private void casess_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            casesForm.Show();
        }

        private void tests_Click(object sender, EventArgs e)
        {
            Tests testsForm = new Tests();
            testsForm.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Equipments equipmentsForm = new Equipments();
            equipmentsForm.Show();
        }
    }
}
