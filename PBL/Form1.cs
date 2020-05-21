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
    public partial class Form1 : Form
    {
        string[] ncrCity =
        {
            "Caloocan City", "Las Pinas City", "Makati City", "Malabon City", "Mandaluyong City", "Manila City", "Marikina City",
            "Muntinlupa City", "Navotas City", "Paranaque City", "Pasay City", "Pasig City", "Quezon City", "San Juan City", "Taguig City", "Valenzuela City"
        };
        string[,] luzonRegionOneToEight =
        {
            // nag multi dimensional array ako
            {"Ilocos Region", "Cagayan Valley", "Central Luzon", "Calabarzon", "Mimaropa", "Bicol Region", "Cordillera Administrative Region" , "NCR"},
            {"Ilocos Norte", "Ilocos Sur", "La Union", "Pangasinan", "","","",""},                     // ilocos region or region 1
            {"Batanes", "Cagayan", "Isabela", "Nueva Vizcaya", "Quirino Province","","",""},           //  region 2 or Cagayan Valley
            {"Aurora", "Bataan", "Bulacan", "Nueva Ecija", "Pampanga", "Tarlac", "Zambales",""},       //region3 or Central Luzon
            {"Cavite", "Laguna","Batangas","Rizal", "Quezon","","",""},                                // region 4 a calabarzon 
            {"Occidental Mindoro", "Oriental Mindoro", "Marinduque", "Romblon", "Palawan", "","",""},  //region 4b mimaropa
            {"Albay", "Camarines Norte", "Camarines Sur", "Sorsogon","Catanduanes", "Masbate", "",""},    //region 5
            {"Abra", "Benguet", "Ifugao", "Kalinga", "Apayao", "Mountain Province", "",""},    //cordilierra administrative region
        };

        public Form1()
        {
            InitializeComponent();
        }
        
        // hide map or back button
        public void hideMap()
        {
            casesLabel.Visible = true;
            casesComboBox.Visible = true;
            bar3.Visible = true;
            colorBehindCases.Visible = true;
            listOfAddedCases.Visible = true;
            regionComboBox.Text = "";
            provinceCityComboBox.Text = "";
            casesComboBox.Text = "";
            informationInProvince.Visible = false;
        }

        // function ko pag kinlick map mag hihide hindi kailangan
        public void showMap()
        {
            // hide mo sila
          
            casesLabel.Visible = false;
            casesComboBox.Visible = false;
            bar3.Visible = false;
            colorBehindCases.Visible = false;
            listOfAddedCases.Visible = false;
            // clear mo laman ng combox
            regionComboBox.Text = "";
            provinceCityComboBox.Text = "";
            casesComboBox.Text = "";
            regionComboBox.Focus();
        }
        public void populateProvince(string selectedRegion)
        {

            int dimension = luzonRegionOneToEight.GetLength(0);
            if (selectedRegion == "Ilocos Region")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[1, i] != string.Empty)
                    {
                        provinceCityComboBox.Items.Add(luzonRegionOneToEight[1, i]);
                    }
                }
            }

            if (selectedRegion == "Cagayan Valley")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[2, i] != string.Empty)
                    {
                        provinceCityComboBox.Items.Add(luzonRegionOneToEight[2, i]);
                    }
                }
            }

            if (selectedRegion == "Central Luzon")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[3, i] != string.Empty)
                    {
                        provinceCityComboBox.Items.Add(luzonRegionOneToEight[3, i]);
                    }
                }
            }

            if (selectedRegion == "Calabarzon")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[4, i] != string.Empty)
                    {
                        provinceCityComboBox.Items.Add(luzonRegionOneToEight[4, i]);
                    }
                }
            }

            if (selectedRegion == "Mimaropa")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[5, i] != string.Empty)
                    {
                        provinceCityComboBox.Items.Add(luzonRegionOneToEight[5, i]);
                    }
                }
            }

            if (selectedRegion == "Bicol Region")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[6, i] != string.Empty)
                    {
                        provinceCityComboBox.Items.Add(luzonRegionOneToEight[6, i]);
                    }
                }
            }

            if (selectedRegion == "Cordillera Administrative Region")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[7, i] != string.Empty)
                    {
                        provinceCityComboBox.Items.Add(luzonRegionOneToEight[7, i]);
                    }
                }
            }
            if (selectedRegion == "NCR")
            {
                provinceCityComboBox.Items.Clear();
                for (int i = 0; i < ncrCity.Length; i++)
                {
                    
                    provinceCityComboBox.Items.Add(ncrCity[i]);
                }
            }
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

        private void cases_Click(object sender, EventArgs e)
        {
            Cases caseForm = new Cases();
            caseForm.Show();
        }

        private void map_Click(object sender, EventArgs e)
        {
            Form1 mapForm = new Form1();
            mapForm.Show();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string regionSelected = regionComboBox.GetItemText(regionComboBox.SelectedItem);
            populateProvince(regionSelected);
            provinceCityComboBox.Text = string.Empty;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void extend_Paint(object sender, PaintEventArgs e)
        {

        }

        private void luzonButton_Click(object sender, EventArgs e)
        {
            showMap();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // populate the choices in region
            int dimension = luzonRegionOneToEight.GetLength(0);
            for (int i = 0; i < dimension;i++)
            {
                if (luzonRegionOneToEight[0, i] != string.Empty)
                {
                    regionComboBox.Items.Add(luzonRegionOneToEight[0, i]);
                }
            }
        }

        private void provinceCityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (provinceCityComboBox.Text != string.Empty && regionComboBox.Text != string.Empty)
            {
                informationInProvince.Visible = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            hideMap();
        }
    }

}
