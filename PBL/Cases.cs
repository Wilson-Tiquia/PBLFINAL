using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Drawing;

namespace PBL
{
    public partial class Cases : Form
    {
        StreamReader deathsStreamReader = new StreamReader("D://Death-Cases.txt");
        
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
            menuPanel.Visible = true;
            mapButton.Visible = true;
            casesButton.Visible = true;
            equipmentsButton.Visible = true;
            testButton.Visible = true;
            equipmentsLabel.Visible = true;
            mapLabel.Visible = true;
            testLabel.Visible = true;
            casesLabel.Visible = true;
        }

        private void extend2_Click(object sender, EventArgs e)
        {
            extend1.Visible = true;
            extend2.Visible = false;
            menuPanel.Visible = false;
            mapButton.Visible = false;
            casesButton.Visible = false;
            equipmentsButton.Visible = false;
            testButton.Visible = false;
            equipmentsLabel.Visible = false;
            mapLabel.Visible = false;
            testLabel.Visible = false;
            casesLabel.Visible = false;
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
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader deathsStreamReader = new StreamReader("D://Death-Cases.txt");

            provinceCityComboBox.Items.Clear();
            //gives only the specific province/city per region selected
            if (regionComboBox.Text == "BARMM")
            {

                provinceCityComboBox.Items.Add("LANAO DEL SUR");
                provinceCityComboBox.Items.Add("MAGUINDANAO");
                provinceCityComboBox.Items.Add("SULU");

            }
            else if (regionComboBox.Text == "CAR")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("ABRA");
                provinceCityComboBox.Items.Add("BAGUIO CITY");
                provinceCityComboBox.Items.Add("BENGUET");
                provinceCityComboBox.Items.Add("IFUGAO");

            }
            else if (regionComboBox.Text == "CARAGA")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("BUTUAN CITY");
            }
            else if (regionComboBox.Text == "NCR")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("QUEZON CITY");
                provinceCityComboBox.Items.Add("CITY OF MANILA");
                provinceCityComboBox.Items.Add("CITY OF PARAÑAQUE");
                provinceCityComboBox.Items.Add("CITY OF MAKATI");
                provinceCityComboBox.Items.Add("CITY OF MANDALUYONG");
                provinceCityComboBox.Items.Add("CITY OF PASIG");
                provinceCityComboBox.Items.Add("TAGUIG CITY");
                provinceCityComboBox.Items.Add("CALOOCAN CITY");
                provinceCityComboBox.Items.Add("PASAY CITY");
                provinceCityComboBox.Items.Add("CITY OF SAN JUAN");
                provinceCityComboBox.Items.Add("CITY OF LAS PIÑAS");
                provinceCityComboBox.Items.Add("CITY OF VALENZUELA");
                provinceCityComboBox.Items.Add("CITY OF MARIKINA");
                provinceCityComboBox.Items.Add("CITY OF MALABON");
                provinceCityComboBox.Items.Add("CITY OF NAVOTAS");
                provinceCityComboBox.Items.Add("PATEROS");
            }
            else if (regionComboBox.Text == "REGION I")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("PANGASINAN");
                provinceCityComboBox.Items.Add("LA UNION");
                provinceCityComboBox.Items.Add("DAGUPAN CITY");
                provinceCityComboBox.Items.Add("ILOCOS NORTE");
                provinceCityComboBox.Items.Add("ILOCOS SUR");

            }
            else if (regionComboBox.Text == "REGION II")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("CAGAYAN");
                provinceCityComboBox.Items.Add("ISABELA");
                provinceCityComboBox.Items.Add("NUEVA VIZCAYA");
                provinceCityComboBox.Items.Add("CITY OF SANTIAGO");
            }
            else if (regionComboBox.Text == "REGION III")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("BULACAN");
                provinceCityComboBox.Items.Add("BATAAN");
                provinceCityComboBox.Items.Add("PAMPANGA");
                provinceCityComboBox.Items.Add("NUEVA ECIJA");
                provinceCityComboBox.Items.Add("TARLAC PROVINCE");
                provinceCityComboBox.Items.Add("OLONGAPO CITY");
                provinceCityComboBox.Items.Add("ZAMBALES");
                provinceCityComboBox.Items.Add("ANGELES CITY");
            }
            else if (regionComboBox.Text == "REGION IV-A")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("RIZAL");
                provinceCityComboBox.Items.Add("LAGUNA");
                provinceCityComboBox.Items.Add("CAVITE");
                provinceCityComboBox.Items.Add("BATANGAS");
                provinceCityComboBox.Items.Add("QUEZON");
                provinceCityComboBox.Items.Add("LUCENA CITY");
            }
            else if (regionComboBox.Text == "REGION IV-B")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("ORIENTAL MINDORO");
                provinceCityComboBox.Items.Add("MARINDUQUE");
                provinceCityComboBox.Items.Add("OCCIDENTAL MINDORO");
                provinceCityComboBox.Items.Add("PUERTO PRINCESA");
                provinceCityComboBox.Items.Add("ROMBLON");

            }
            else if (regionComboBox.Text == "REGION IX")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("ZAMBOANGA CITY");
                provinceCityComboBox.Items.Add("ZAMBOANGA DEL SUR");
            }
            else if (regionComboBox.Text == "REGION V")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("ALBAY");
                provinceCityComboBox.Items.Add("NAGA CITY");
                provinceCityComboBox.Items.Add("CAMARINES SUR");
                provinceCityComboBox.Items.Add("CAMARINES NORTE");
                provinceCityComboBox.Items.Add("CATANDUANES");
                provinceCityComboBox.Items.Add("SORSOGON");

            }
            else if (regionComboBox.Text == "REGION VI")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("ILOILO CITY");
                provinceCityComboBox.Items.Add("ILOILO PROVINCE");
                provinceCityComboBox.Items.Add("ANTIQUE");
                provinceCityComboBox.Items.Add("BACOLOD CITY");
                provinceCityComboBox.Items.Add("NEGROS OCCIDENTAL");
                provinceCityComboBox.Items.Add("AKLAN");
                provinceCityComboBox.Items.Add("CAPIZ");
                provinceCityComboBox.Items.Add("GUIMARAS");

            }
            else if (regionComboBox.Text == "REGION VII")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("CEBU CITY");
                provinceCityComboBox.Items.Add("MANDAUE CITY");
                provinceCityComboBox.Items.Add("LAPU-LAPU CITY");
                provinceCityComboBox.Items.Add("CEBU PROVINCE");
                provinceCityComboBox.Items.Add("NEGROS ORIENTAL");
                provinceCityComboBox.Items.Add("BOHOL");

            }
            else if (regionComboBox.Text == "REGION VIII")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("SAMAR");
                provinceCityComboBox.Items.Add("LEYTE");
                provinceCityComboBox.Items.Add("NORTHERN SAMAR");
            }
            else if (regionComboBox.Text == "REGION X")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("CAGAYAN DE ORO");
                provinceCityComboBox.Items.Add("MISAMIS OCCIDENTAL");
                provinceCityComboBox.Items.Add("ILIGAN CITY");
                provinceCityComboBox.Items.Add("LANAO DEL NORTE");
                provinceCityComboBox.Items.Add("BUKIDNON");
                provinceCityComboBox.Items.Add("CAMIGUIN");
            }
            else if (regionComboBox.Text == "REGION XI")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("DAVAO CITY");
                provinceCityComboBox.Items.Add("DAVAO DEL SUR");
                provinceCityComboBox.Items.Add("DAVAO ORIENTAL");
                provinceCityComboBox.Items.Add("DAVAO OCCIDENTAL");
                provinceCityComboBox.Items.Add("COMPOSTELA VALLEY");
                provinceCityComboBox.Items.Add("DAVAO DEL NORTE");

            }
            else if (regionComboBox.Text == "REGION XII")
            {
                provinceCityComboBox.Items.Clear();
                provinceCityComboBox.Items.Add("COTABATO CITY");
                provinceCityComboBox.Items.Add("COTABATO");
                provinceCityComboBox.Items.Add("SOUTH COTABATO");
                provinceCityComboBox.Items.Add("SULTAN KUDARAT");
                provinceCityComboBox.Items.Add("GEENRAL SANTOS");
                provinceCityComboBox.Items.Add("SARANGANI");
            }
            if (regionComboBox.SelectedIndex > -1)
            {
                listView2.Items.Clear();
                listView1.Items.Clear();
                string tofind = regionComboBox.SelectedItem.ToString();
                
               

                while (deathsStreamReader.Peek() != -1)
                {
                    string x = deathsStreamReader.ReadLine();
                    
                    string[] xe = x.Split(',');
                    ListViewItem lvi = new ListViewItem(xe[0]);
                    ListViewItem lvi1 = new ListViewItem(xe[0]);

                    lvi.SubItems.Add(xe[1]);
                    lvi.SubItems.Add(xe[2]);
                    lvi.SubItems.Add(xe[3]);
                    listView2.Items.Add(lvi);
                    if (xe[0] == tofind)
                    {
                        lvi1.SubItems.Add(xe[1]);
                        lvi1.SubItems.Add(xe[2]);
                        lvi1.SubItems.Add(xe[3]);
                        listView1.Items.Add(lvi1);
                        listView2.Items[0].Focused = true;
                        listView2.Items[0].Selected = true;

                    }

               }
                deathsStreamReader.Close();
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cases_Load(object sender, EventArgs e)
        {

            int totalRC = 0;
            int totalDC = 0;
            if (regionComboBox.SelectedIndex > 1)
            {
                listView2.Items.Clear();
                listView1.Items.Clear();

                string tofind = regionComboBox.SelectedItem.ToString();
                
                

                while (deathsStreamReader.Peek() != -1)
                {
                    string x = deathsStreamReader.ReadLine();
                    
                    string[] xe = x.Split(',');
                    totalRC = totalRC + Convert.ToInt32(xe[2]);
                    totalDC = totalDC + Convert.ToInt32(xe[3]);
                    if (xe[0] == tofind)
                    {
                        ListViewItem lvi = new ListViewItem(xe[0]);
                        ListViewItem lvi1 = new ListViewItem(xe[0]);

                        lvi.SubItems.Add(xe[1]);
                        lvi.SubItems.Add(xe[2]);
                        lvi.SubItems.Add(xe[3]);
                        listView2.Items.Add(lvi);

                        lvi1.SubItems.Add(xe[1]);
                        lvi1.SubItems.Add(xe[2]);
                        lvi1.SubItems.Add(xe[3]);
                        listView1.Items.Add(lvi1);

                    }

                }
                deathsStreamReader.Close();
                recoveredDeathChart.Series["Death"].Points.AddXY("Total", deathNumber);
                recoveredDeathChart.Series["Recovered"].Points.AddXY("Total", recoveredNumber);
                
            }
            else
            {
                

                while (deathsStreamReader.Peek() != -1)
                {
                    string x = deathsStreamReader.ReadLine();
                    
                    string[] xe = x.Split(',');
                    
                    totalRC += Convert.ToInt32(xe[2]);
                    totalDC = totalDC + Convert.ToInt32(xe[3]);

                    ListViewItem lvi = new ListViewItem(xe[0]);
                    ListViewItem lvi1 = new ListViewItem(xe[0]);

                    lvi.SubItems.Add(xe[1]);
                    lvi.SubItems.Add(xe[2]);
                    lvi.SubItems.Add(xe[3]);
                    listView2.Items.Add(lvi);

                    lvi1.SubItems.Add(xe[1]);
                    lvi1.SubItems.Add(xe[2]);
                    lvi1.SubItems.Add(xe[3]);
                    listView1.Items.Add(lvi1);
                }
                deathsStreamReader.Close();
                
            }
            deathNumber.Text = totalRC.ToString();
            recoveredNumber.Text = totalDC.ToString();
            recoveredDeathChart.Series["Deaths"].Points.AddXY("Total", deathNumber.Text);
            recoveredDeathChart.Series["Recovered"].Points.AddXY("Total", recoveredNumber.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           StreamReader deathsStreamReader = new StreamReader("D://Death-Cases.txt");
            
            if (provinceCityComboBox.SelectedIndex > -1)
            {
                listView2.Items.Clear();
                listView1.Items.Clear();

                string tofind = provinceCityComboBox.SelectedItem.ToString();


                while (deathsStreamReader.Peek() != -1)
                {

                     string x = deathsStreamReader.ReadLine();
                   
                    string[] xe = x.Split(',');
                    ListViewItem lvi = new ListViewItem(xe[0]);
                    ListViewItem lvi1 = new ListViewItem(xe[0]);
                    lvi.SubItems.Add(xe[1]);
                    lvi.SubItems.Add(xe[2]);
                    lvi.SubItems.Add(xe[3]);
                    listView2.Items.Add(lvi);
                    if (xe[1] == tofind)
                    {
                        lvi1.SubItems.Add(xe[1]);
                        lvi1.SubItems.Add(xe[2]);
                        lvi1.SubItems.Add(xe[3]);
                        listView1.Items.Add(lvi1);

                        listView2.Items[0].Focused = true;
                        listView2.Items[0].Selected = true;


                    }

                }
               deathsStreamReader.Close();
                listView2.Visible = false;
                listView1.Visible = true;

            }
        }



 

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //Stream Writer
            listView2.SelectedItems.Clear();
           StreamWriter sw = new StreamWriter("D://Death-Cases.txt", false);
            


            foreach (ListViewItem itemRow in listView2.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    sw.Write(itemRow.SubItems[i].Text);
                    
                    if (i < listView2.Columns.Count - 1)
                    {
                         sw.Write(",");
                       
                    }

                }
                sw.Write(sw.NewLine);
                
            }
            sw.Close();

            listView2.Visible = true;
            listView1.Visible = false;
            recoveredTextBox.Clear();
            deathTextBix.Clear();

            MessageBox.Show("Saved!!!");
            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("JeonLana", "lana0316");
            client.UploadFile("ftp://66.220.9.50/My Documents/Sample.txt", "D://Death-Cases.txt");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string cmb1 = regionComboBox.Text.ToString();
            string cmb2 = provinceCityComboBox.Text.ToString();
            int val1;
            int val2;

            if (deathTextBix.Text == "")
            {
                val1 = 0;
            }
            else
            {
                val1 = Convert.ToInt32(deathTextBix.Text);
            }
            if (recoveredTextBox.Text == "")
            {
                val2 = 0;
            }
            else
            {
                val2 = Convert.ToInt32(recoveredTextBox.Text);
            }

            StreamReader deathsStreamReader = new StreamReader("D://Death-Cases.txt");
            
            listView2.Items.Clear();
            listView1.Items.Clear();

            string tofind = provinceCityComboBox.SelectedItem.ToString();

            
            while (deathsStreamReader.Peek() != -1)
            {
                string x = deathsStreamReader.ReadLine();
               
                string[] xe = x.Split(',');
                ListViewItem lvi = new ListViewItem(xe[0]);
                lvi.SubItems.Add(xe[1]);
                if (xe[1] == tofind)
                {
                    ListViewItem lvi1 = new ListViewItem(xe[0]);
                    lvi1.SubItems.Add(xe[1]);

                    if (xe[1] == cmb2 && xe[0] == cmb1)
                    {
                        val2 = Convert.ToInt32(xe[3]) + val2;
                        val1 = Convert.ToInt32(xe[2]) + val1;
                        lvi.SubItems.Add(val1.ToString());
                        lvi.SubItems.Add(val2.ToString());
                        lvi1.SubItems.Add(val1.ToString());
                        lvi1.SubItems.Add(val2.ToString());
                        listView1.Items.Add(lvi1);

                    }
                }
                else
                {
                    lvi.SubItems.Add(xe[2]);
                    lvi.SubItems.Add(xe[3]);
                }
                
                listView2.Items.Add(lvi);
            }
             deathsStreamReader.Close();
            


        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string cmb1 = regionComboBox.Text.ToString();
            string cmb2 = provinceCityComboBox.Text.ToString();
            int val1;
            int val2;

            if (deathTextBix.Text == "")
            {
                val1 = 0;
            }
            else
            {
                val1 = Convert.ToInt32(deathTextBix.Text);
            }
            if (recoveredTextBox.Text == "")
            {
                val2 = 0;
            }
            else
            {
                val2 = Convert.ToInt32(recoveredTextBox.Text);
            }



            StreamReader deathsStreamReader = new StreamReader("D://Death-Cases.txt");

            listView2.Items.Clear();
            listView1.Items.Clear();

            string tofind = provinceCityComboBox.SelectedItem.ToString();

            
            while (deathsStreamReader.Peek() != -1)
            {
                string x = deathsStreamReader.ReadLine();
                
                string[] xe = x.Split(',');
                ListViewItem lvi = new ListViewItem(xe[0]);
                lvi.SubItems.Add(xe[1]);
                if (xe[1] == tofind)
                {
                    ListViewItem lvi1 = new ListViewItem(xe[0]);
                    lvi1.SubItems.Add(xe[1]);

                    if (xe[1] == cmb2 && xe[0] == cmb1)
                    {
                        val2 = Convert.ToInt32(xe[3]) + val2;
                        val1 = Convert.ToInt32(xe[2]) + val1;
                        lvi.SubItems.Add(val1.ToString());
                        lvi.SubItems.Add(val2.ToString());
                        lvi1.SubItems.Add(val1.ToString());
                        lvi1.SubItems.Add(val2.ToString());
                        listView1.Items.Add(lvi1);

                    }
                }
                else
                {
                    lvi.SubItems.Add(xe[2]);
                    lvi.SubItems.Add(xe[3]);
                }
                
                listView2.Items.Add(lvi);
            }
            deathsStreamReader.Close();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Minimized;
            TopMost = false;
        }

        private void minimize(object sender, EventArgs e)
        {
            this.Width = 550;
            this.Height = 370;
            minimizeButton.Visible = false;
            maximizeButton.Visible = true;
        }

        private void maximize(object sender, EventArgs e)
        {
            this.Width = 1290;
            this.Height = 770;
            maximizeButton.Visible = false;
            minimizeButton.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recoveredCasesLabel_Click(object sender, EventArgs e)
        {

        }

        private void deathCasesLabel_Click(object sender, EventArgs e)
        {

        }

        private void recoveredDeathChart_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
