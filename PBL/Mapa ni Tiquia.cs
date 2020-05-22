using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PBL
{
    public partial class Mapa_ni_Tiquia : Form
    {
        string[] islandList = { "Luzon", "Visayas", "Mindanao" };
        string[] ncrCity =
        {
            "Caloocan City", "Las Pinas City", "Makati City", "Malabon City", "Mandaluyong City", "Manila City", "Marikina City",
            "Muntinlupa City", "Navotas City", "Paranaque City", "Pasay City", "Pasig City", "Quezon City", "San Juan City", "Taguig City", "Valenzuela City"
        };
        string[,] luzonRegionOneToEight =
        {
            // nag multi dimensional array ako
            {"Region I", "Region II", "Region III", "Region IV-A", "Region IV-B", "Region V", "Cordillera Administrative Region" , "NCR"},
            {"Ilocos Norte", "Ilocos Sur", "La Union", "Pangasinan", "","","",""},                     // ilocos region or region 1
            {"Batanes", "Cagayan", "Isabela", "Nueva Vizcaya", "Quirino Province","","",""},           //  region 2 or Cagayan Valley
            {"Aurora", "Bataan", "Bulacan", "Nueva Ecija", "Pampanga", "Tarlac", "Zambales",""},       //region3 or Central Luzon
            {"Cavite", "Laguna","Batangas","Rizal", "Quezon","","",""},                                // region 4 a calabarzon 
            {"Occidental Mindoro", "Oriental Mindoro", "Marinduque", "Romblon", "Palawan", "","",""},  //region 4b mimaropa
            {"Albay", "Camarines Norte", "Camarines Sur", "Sorsogon","Catanduanes", "Masbate", "",""},    //region 5
            {"Abra", "Benguet", "Ifugao", "Kalinga", "Apayao", "Mountain Province", "",""},    //cordilierra administrative region
        };
        string[,] visayasRegionSixToEight =
        {
            {"Region VI", "Region VII", "Region VIII", "", "", ""},
            {"Aklan", "Antique", "Capiz", "Guimaras", "Iloilo", "Negros Occidental" },  // western visayas Regionn 6
            {"Cebu", "Bohol", "Negros Oriental", "Siquijor", "", "" }, // central visayas region 7
            {"Leyte", "Biliran", "Southern Leyte", "Samar", "Eastern Samar", "Northern Samar"  }, // eastern visayas
        };

        string[,] mindanaoRegions =
        {
            {"Region IX", "Region X", "Region XI", "Region XII","Region XIII", "BARMM" },
            {"Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay", "", "", "" }, //Zamboanga Peninsula Region 9
            {"Misamis Oriental", "Misamis Occidental", "Bukidnon", "Camiguin", "Lanao del Norte", "" },         // region 10 northern mindanao
            {"Davao de Oro", "Davao del Norte", "Davao del Sur", "Davao Oriental", "Davao Occidental",""},      // region 11 southern mindanao dabao region
            {"South Cotabato", "Cotabato", "Sultan Kudarat", "Sarangani", "", "" },         //central mindanao sooccsargen 12
            {"Agusan del Norte", "Agusan del Sur", "Surigao del Norte", "Surigao del Sur", "Dinagat Islands", "" }, // region 13 caraga
            {"Lanao del Sur", "Maguindanao", "Sulu", "Tawi-tawi", "", ""},                  // BARMM
        };
        public Mapa_ni_Tiquia()
        {
            InitializeComponent();
        }

        public void populateIsland()
        {
            for (int i = 0; i < islandList.Length;i++)
            {
                islandComboBox.Items.Add(islandList[i]);
            }
        }
        public void populateRegions(string island)
        {
            int dimension = 0;
            if (island == "Luzon")
            {
                regionComboBox.Items.Clear();
                dimension = luzonRegionOneToEight.GetLength(0);
                for (int i = 0; i <dimension;i++)
                {
                    if (luzonRegionOneToEight[0,i] != string.Empty)
                    {
                        regionComboBox.Items.Add(luzonRegionOneToEight[0, i]);
                    }
                }

            }
            if (island == "Visayas")
            {
                regionComboBox.Items.Clear();
                dimension = visayasRegionSixToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (visayasRegionSixToEight[0, i] != string.Empty)
                    {
                        regionComboBox.Items.Add(visayasRegionSixToEight[0, i]);
                    }
                }

            }
            if (island == "Mindanao")
            {
                regionComboBox.Items.Clear();
                dimension = mindanaoRegions.GetLength(1);
                for (int i = 0; i < dimension; i++)
                {
                    if (mindanaoRegions[0, i] != string.Empty)
                    {
                        regionComboBox.Items.Add(mindanaoRegions[0, i]);
                    }
                }
            }
        }
        public void populateProvince(string region)
        {
            int dimension = 0;
            // buonng luzon
            if (region == "Region I")
            {
                dimension = luzonRegionOneToEight.GetLength(0); 
                for (int i = 0; i <dimension;i++ )
                {
                    if (luzonRegionOneToEight[1,i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(luzonRegionOneToEight[1, i]);
                    }
                }
            }
            if (region == "Region II")
            {
                dimension = luzonRegionOneToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[2, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(luzonRegionOneToEight[2, i]);
                    }
                }
            }
            if (region == "Region III")
            {
                dimension = luzonRegionOneToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[3, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(luzonRegionOneToEight[3, i]);
                    }
                }
            }

            if (region == "Region IV-A")
            {
                dimension = luzonRegionOneToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[4, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(luzonRegionOneToEight[4, i]);
                    }
                }
            }
            if (region == "Region IV-B")
            {
                dimension = luzonRegionOneToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[5, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(luzonRegionOneToEight[5, i]);
                    }
                }
            }
            if (region == "Region V")
            {
                dimension = luzonRegionOneToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[6, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(luzonRegionOneToEight[6, i]);
                    }
                }
            }
            if (region == "Cordillera Administrative Region")
            {
                dimension = luzonRegionOneToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (luzonRegionOneToEight[7, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(luzonRegionOneToEight[7, i]);
                    }
                }
            }
            // end ng luzon
            // start ng visayas
            if (region == "Region VI")
            {
                dimension = visayasRegionSixToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (visayasRegionSixToEight[1, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(visayasRegionSixToEight[1, i]);
                    }
                }
            }
            if (region == "Region VII")
            {
                dimension = visayasRegionSixToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (visayasRegionSixToEight[2, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(visayasRegionSixToEight[2, i]);
                    }
                }
            }
            if (region == "Region VIII")
            {
                dimension = visayasRegionSixToEight.GetLength(0);
                for (int i = 0; i < dimension; i++)
                {
                    if (visayasRegionSixToEight[3, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(visayasRegionSixToEight[3, i]);
                    }
                }
            }
            // end ng visayas
            // start ng sa mindanao
            // length of column kinukuha kasi 6 column 7 rows e column long kailangan
            if (region == "Region IX")
            {
                dimension = mindanaoRegions.GetLength(1);
                for (int i = 0; i < dimension; i++)
                {
                    if (mindanaoRegions[1, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(mindanaoRegions[1, i]);
                    }
                }
            }
            if (region == "Region X")
            {
                dimension = mindanaoRegions.GetLength(1);
                for (int i = 0; i < dimension; i++)
                {
                    if (mindanaoRegions[2, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(mindanaoRegions[2, i]);
                    }
                }
            }
            if (region == "Region XI")
            {
                dimension = mindanaoRegions.GetLength(1);
                for (int i = 0; i < dimension; i++)
                {
                    if (mindanaoRegions[3, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(mindanaoRegions[3, i]);
                    }
                }
            }
            if (region == "Region XII")
            {
                dimension = mindanaoRegions.GetLength(1);
                for (int i = 0; i < dimension; i++)
                {
                    if (mindanaoRegions[4, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(mindanaoRegions[4, i]);
                    }
                }
            }
            if (region == "Region XIII")
            {
                dimension = visayasRegionSixToEight.GetLength(1);
                for (int i = 0; i < dimension; i++)
                {
                    if (mindanaoRegions[5, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(mindanaoRegions[5, i]);
                    }
                }
            }
            if (region == "BARMM")
            {
                dimension = mindanaoRegions.GetLength(1);
                for (int i = 0; i < dimension; i++)
                {
                    if (visayasRegionSixToEight[6, i] != string.Empty)
                    {
                        provinceComboBox.Items.Add(mindanaoRegions[6, i]);
                    }
                }
            }





        }
        private void Mapa_ni_Tiquia_Load(object sender, EventArgs e)
        {
            populateIsland();
        }

        private void islandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIsland = islandComboBox.GetItemText(islandComboBox.SelectedItem);
            provinceComboBox.Text = string.Empty;
            populateRegions(selectedIsland);

        }

        private void provinceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRegion = regionComboBox.GetItemText(regionComboBox.SelectedItem);
            provinceComboBox.Items.Clear();
            populateProvince(selectedRegion);

            
        }

        private void islandComboBox_DropDown(object sender, EventArgs e)
        {
            regionComboBox.Text = string.Empty;
            provinceComboBox.Text = string.Empty;
        }

        private void regionComboBox_DropDown(object sender, EventArgs e)
        {
            provinceComboBox.Text = string.Empty;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void caseInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            bool mayLamanIslandRegionAtProvince = islandComboBox.Text != string.Empty && regionComboBox.Text != string.Empty && provinceComboBox.Text != string.Empty;
            if (e.KeyCode == Keys.Enter && mayLamanIslandRegionAtProvince)
            {
                MessageBox.Show("Added user");
                string[] addedCase = { islandComboBox.Text, ", ",regionComboBox.Text, ", ", provinceComboBox.Text, ", ", caseInputTextBox.Text };
                StreamWriter addUser = new StreamWriter("C:\\ADDCASE\\newcases.txt", true);
                for (int i = 0; i < addedCase.Length; i++)
                {
                    addUser.Write(addedCase[i]);
                }
                addUser.WriteLine();
                addUser.Close();
                islandComboBox.Text = regionComboBox.Text = provinceComboBox.Text = caseInputTextBox.Text = string.Empty;
                islandComboBox.Focus();
                


            }
         
        }
    }
}
