using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class Tests : Form
    {
        public Tests()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void map_Click(object sender, EventArgs e)
        {
            Form1 mapForm = new Form1();
            mapForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            casesForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tests testsForm = new Tests();
            testsForm.Show();
        }

        private void equipments_Click(object sender, EventArgs e)
        {
            Equipments equipmentsForms = new Equipments();
            equipmentsForms.Show();
        }

        private void extend_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
            TopMost = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            this.Height = 370;
            pictureBox6.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Width = 1290;
            this.Height = 770;
            pictureBox6.Visible = true;
            pictureBox4.Visible = false;
        }

        private void extend1_Click_1(object sender, EventArgs e)
        {
            panel16.Visible = true;
            map.Visible = true;
            casess.Visible = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            extend2.Visible = true;
            extend1.Visible = false;
        }

        private void extend2_Click_1(object sender, EventArgs e)
        {
            panel16.Visible = false;
            map.Visible = false;
            casess.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            extend2.Visible = false;
            extend1.Visible = true;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
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

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Tests testsForm = new Tests();
            testsForm.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Equipments equipmentsForm = new Equipments();
            equipmentsForm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openAdd_Click(object sender, EventArgs e)
        {
            cumulativePanel.Visible = true;
            hospitalLabel.Visible = true;
            hospitalPanel.Visible = true;
            hospitalComboBox.Visible = true;
            uniqueLabel.Visible = true;
            uniquePanel.Visible = true;
            uniqueTextBox.Visible = true;
            positiveLabel.Visible = true;
            positivePanel.Visible = true;
            positiveTextBox.Visible = true;
            negativeLabel.Visible = true;
            negativePanel.Visible = true;
            negativeTextBox.Visible = true;
            equivocalLabel.Visible = true;
            equivocalPanel.Visible = true;
            equivocalTextBox.Visible = true;
            invalidLabel.Visible = true;
            invalidPanel.Visible = true;
            invalidTextBox.Visible = true;
            totalLabel.Visible = true;
            totalPanel.Visible = true;
            totalTextBox.Visible = true;
            remainingLabel.Visible = true;
            remainingPanel.Visible = true;
            remainingTextBox.Visible = true;
            openAdd.Visible = false;
            closeAdd.Visible = true;
        }

        private void closeAdd_Click(object sender, EventArgs e)
        {
            cumulativePanel.Visible = false;
            hospitalLabel.Visible = false;
            hospitalPanel.Visible = false;
            hospitalComboBox.Visible = false;
            uniqueLabel.Visible = false;
            uniquePanel.Visible = false;
            uniqueTextBox.Visible = false;
            positiveLabel.Visible = false;
            positivePanel.Visible = false;
            positiveTextBox.Visible = false;
            negativeLabel.Visible = false;
            negativePanel.Visible = false;
            negativeTextBox.Visible = false;
            equivocalLabel.Visible = false;
            equivocalPanel.Visible = false;
            equivocalTextBox.Visible = false;
            invalidLabel.Visible = false;
            invalidPanel.Visible = false;
            invalidTextBox.Visible = false;
            totalLabel.Visible = false;
            totalPanel.Visible = false;
            totalTextBox.Visible = false;
            remainingLabel.Visible = false;
            remainingPanel.Visible = false;
            remainingTextBox.Visible = false;
            openAdd.Visible = true;
            closeAdd.Visible = false;
        }

        private void openTest_Click(object sender, EventArgs e)
        {
            testPanel.Visible = true;
            hospitalLabel.Visible = true;
            hospitalComboBox.Visible = true;
            hospitalPanel.Visible = true;
            dateLabel.Visible = true;
            dateTimePicker1.Visible = true;
            datePanel.Visible = true;
            conductedLabel.Visible = true;
            conductedPanel.Visible = true;
            conductedTextBox.Visible = true;
            openTest.Visible = false;
            closeTest.Visible = true;
        }

        private void closeTest_Click(object sender, EventArgs e)
        {
            testPanel.Visible = false;
            hospitalLabel.Visible = false;
            hospitalComboBox.Visible = false;
            hospitalPanel.Visible = false;
            dateLabel.Visible = false;
            dateTimePicker1.Visible = false;
            datePanel.Visible = false;
            conductedLabel.Visible = false;
            conductedPanel.Visible = false;
            conductedTextBox.Visible = false;
            openTest.Visible = true;
            closeTest.Visible = false;
        }
    }
}
