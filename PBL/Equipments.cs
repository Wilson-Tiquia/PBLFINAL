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
            extend1.Visible = false;
            extend2.Visible = true;
            extend.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void extend2_Click(object sender, EventArgs e)
        {
            extend1.Visible = true;
            extend2.Visible = false;
            extend.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
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


    }
}
