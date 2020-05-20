using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL
{
    public partial class Cases : Form
    {
        public Cases()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            Form1 mapForm = new Form1();
            mapForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cases casesForm = new Cases();
            casesForm.Show();
        }

        private void tests_Click(object sender, EventArgs e)
        {
            Tests testsForm = new Tests();
            testsForm.Show();
        }

        private void equipments_Click(object sender, EventArgs e)
        {
            Equipments equipmentsForm = new Equipments();
            equipmentsForm.Show();
        }

        

        private void textBox3_Click(object sender, EventArgs e)
        {
            label18.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gives only the specific province/city per region selected
            if (comboBox1.Text == "BARMM")
            {
                comboBox2.Items.Add("LANAO DEL SUR");
                comboBox2.Items.Add("MAGUINDANAO");
                comboBox2.Items.Add("SULU");

            }
            else if (comboBox1.Text == "CAR")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ABRA");
                comboBox2.Items.Add("BAGUIO CITY");
                comboBox2.Items.Add("BENGUET");
                comboBox2.Items.Add("IFUGAO");

            }
            else if (comboBox1.Text == "CARAGA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("BUTUAN CITY");
            }
            else if (comboBox1.Text == "NCR")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("QUEZON CITY");
                comboBox2.Items.Add("CITY OF MANILA");
                comboBox2.Items.Add("CITY OF PARAÑAQUE");
                comboBox2.Items.Add("CITY OF MAKATI");
                comboBox2.Items.Add("CITY OF MANDALUYONG");
                comboBox2.Items.Add("CITY OF PASIG");
                comboBox2.Items.Add("TAGUIG CITY");
                comboBox2.Items.Add("CALOOCAN CITY");
                comboBox2.Items.Add("PASAY CITY");
                comboBox2.Items.Add("CITY OF SAN JUAN");
                comboBox2.Items.Add("CITY OF LAS PIÑAS");
                comboBox2.Items.Add("CITY OF VALENZUELA");
                comboBox2.Items.Add("CITY OF MARIKINA");
                comboBox2.Items.Add("CITY OF MALABON");
                comboBox2.Items.Add("CITY OF NAVOTAS");
                comboBox2.Items.Add("PATEROS");
            }
            else if (comboBox1.Text == "REGION I")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("PANGASINAN");
                comboBox2.Items.Add("LA UNION");
                comboBox2.Items.Add("DAGUPAN CITY");
                comboBox2.Items.Add("ILOCOS NORTE");
                comboBox2.Items.Add("ILOCOS SUR");

            }
            else if (comboBox1.Text == "REGION II")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CAGAYAN");
                comboBox2.Items.Add("ISABELA");
                comboBox2.Items.Add("NUEVA VIZCAYA");
                comboBox2.Items.Add("CITY OF SANTIAGO");
            }
            else if (comboBox1.Text == "REGION III")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("BULACAN");
                comboBox2.Items.Add("BATAAN");
                comboBox2.Items.Add("PAMPANGA");
                comboBox2.Items.Add("NUEVA ECIJA");
                comboBox2.Items.Add("TARLAC PROVINCE");
                comboBox2.Items.Add("OLONGAPO CITY");
                comboBox2.Items.Add("ZAMBALES");
                comboBox2.Items.Add("ANGELES CITY");
            }
            else if (comboBox1.Text == "REGION IV-A")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("RIZAL");
                comboBox2.Items.Add("LAGUNA");
                comboBox2.Items.Add("CAVITE");
                comboBox2.Items.Add("BATANGAS");
                comboBox2.Items.Add("QUEZON");
                comboBox2.Items.Add("LUCENA CITY");
            }
            else if (comboBox1.Text == "REGION IV-B")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ORIENTAL MINDORO");
                comboBox2.Items.Add("MARINDUQUE");
                comboBox2.Items.Add("OCCIDENTAL MINDORO");
                comboBox2.Items.Add("PUERTO PRINCESA");
                comboBox2.Items.Add("ROMBLON");

            }
            else if (comboBox1.Text == "REGION IX")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ZAMBOANGA CITY");
                comboBox2.Items.Add("ZAMBOANGA DEL SUR");
            }
            else if (comboBox1.Text == "REGION V")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ALBAY");
                comboBox2.Items.Add("NAGA CITY");
                comboBox2.Items.Add("CAMARINES SUR");
                comboBox2.Items.Add("CAMARINES NORTE");
                comboBox2.Items.Add("CATANDUANES");
                comboBox2.Items.Add("SORSOGON");

            }
            else if (comboBox1.Text == "REGION VI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("ILOILO CITY");
                comboBox2.Items.Add("ILOILO PROVINCE");
                comboBox2.Items.Add("ANTIQUE");
                comboBox2.Items.Add("BACOLOD CITY");
                comboBox2.Items.Add("NEGROS OCCIDENTAL");
                comboBox2.Items.Add("AKLAN");
                comboBox2.Items.Add("CAPIZ");
                comboBox2.Items.Add("GUIMARAS");

            }
            else if (comboBox1.Text == "REGION VII")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CEBU CITY");
                comboBox2.Items.Add("MANDAUE CITY");
                comboBox2.Items.Add("LAPU-LAPU CITY");
                comboBox2.Items.Add("CEBU PROVINCE");
                comboBox2.Items.Add("NEGROS ORIENTAL");
                comboBox2.Items.Add("BOHOL");

            }
            else if (comboBox1.Text == "REGION VIII")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("SAMAR");
                comboBox2.Items.Add("LEYTE");
                comboBox2.Items.Add("NORTHERN SAMAR");
            }
            else if (comboBox1.Text == "REGION X")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("CAGAYAN DE ORO");
                comboBox2.Items.Add("MISAMIS OCCIDENTAL");
                comboBox2.Items.Add("ILIGAN CITY");
                comboBox2.Items.Add("LANAO DEL NORTE");
                comboBox2.Items.Add("BUKIDNON");
                comboBox2.Items.Add("CAMIGUIN");
            }
            else if (comboBox1.Text == "REGION XI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DAVAO CITY");
                comboBox2.Items.Add("DAVAO DEL SUR");
                comboBox2.Items.Add("DAVAO ORIENTAL");
                comboBox2.Items.Add("DAVAO OCCIDENTAL");
                comboBox2.Items.Add("COMPOSTELA VALLEY");
                comboBox2.Items.Add("DAVAO DEL NORTE");

            }
            else if (comboBox1.Text == "REGION XII")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("COTABATO CITY");
                comboBox2.Items.Add("COTABATO");
                comboBox2.Items.Add("SOUTH COTABATO");
                comboBox2.Items.Add("SULTAN KUDARAT");
                comboBox2.Items.Add("GEENRAL SANTOS");
                comboBox2.Items.Add("SARANGANI");
            }
        }
    }
}
