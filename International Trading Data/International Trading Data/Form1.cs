using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace International_Trading_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            biggestPotentialClickLabel.Text = "Click to see the country\nwith biggest potential trade";
        }
        private List<string> items = new List<string>(); //store all the country names in a list
        private AVLTree<Country> avl = new AVLTree<Country>(); //store all the countries in an avl tree
        private LinkedList<string> mainTradePartners = new LinkedList<string>(); //store all the trade partners for each country

        private void loadButton_Click(object sender, EventArgs e)
        {
            string[] headers = new string[6];
            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];
            OpenFileDialog f = new OpenFileDialog();
            f.ShowDialog();
            f.OpenFile();
            AllLines = File.ReadAllLines(f.FileName);
            foreach(string line in AllLines)
            {

                if (line.StartsWith("Country"))
                {
                    headers = line.Split(',');
                }
                else
                {
                    string[] columns = line.Split(',');
                    string[] partners = columns[5].Split(';', '[', ']');
                    foreach(string tradePartner in partners)
                    {
                        if (tradePartner != "")
                        {
                            mainTradePartners.AddFirst(tradePartner);
                        }
                    }
                    Country country = new Country(columns[0], columns[1], columns[2], columns[3], columns[4], mainTradePartners);
                    mainTradePartners = new LinkedList<string>();
                    avl.InsertItem(country);
                    allCountriesListBox.Items.Add(country.Name);
                }
                
            }
            treeHightLabel.Text = "Height of the tree: "+avl.Height();
            treeCountLabel.Text = "Number of countries: " + avl.Count();
            for (int i = 0; i < allCountriesListBox.Items.Count; i++)
            {
                items.Add(allCountriesListBox.Items[i].ToString());
            }

        }

        private void allCountriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Country country in avl.GetEnumerator())
            {
                if (country.Name == allCountriesListBox.SelectedItem.ToString())
                {
                    string partners = "";
                    foreach (string s in country.MainTradePartners)
                    {
                        partners += "    " + s.ToUpper() + "\n";
                    }
                    countryInformationBox.Text = "Country: ".ToUpper() + country.Name.ToUpper() + "\n"
                        + "GDP Growth: " + country.GdpGrowth + "\n"
                        + "Inflation: " + country.Inflation+ "\n"
                        + "Trade Balance: " + country.TradeBalance + "\n"
                        + "Hdi Ranking: " + country.HdiRanking + "\n"
                        + "Main Trade Partners:" + "\n"
                        + partners;
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach(Country country in avl.GetEnumerator())
            {
                if (country.Name == allCountriesListBox.SelectedItem.ToString())
                {
                    avl.RemoveItem(country);
                    avl.c = 0;
                }
            }
            items.Clear();
            for (int i = 0; i < allCountriesListBox.Items.Count; i++)
            {
                items.Add(allCountriesListBox.Items[i].ToString());
            }
            allCountriesListBox.Items.Clear();
            foreach (Country country in avl.GetEnumerator())
            {
                allCountriesListBox.Items.Add(country.Name);
            }
            treeHightLabel.Text = "Height of the tree: " + avl.Height();
            treeCountLabel.Text = "Number of countries: " + avl.Count();
            inOrderRadioButton.Checked = false;
        }

        private void searchPartnerButton_Click(object sender, EventArgs e)
        {
            allCountriesListBox.Items.Clear();
            foreach(Country country in avl.GetEnumerator())
            {
                foreach(string s in country.MainTradePartners)
                {
                    if (s == searchPartnerTextBox.Text)
                    {
                        foreach (string m in country.MainTradePartners)
                        {
                            if (s == m)
                                allCountriesListBox.Items.Add(country.Name);
                        }
                    }
                }
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            allCountriesListBox.Items.Clear();
            for (int i=0; i<items.Count; i++)
            {
                if (items[i].ToString().ToLower().Contains(searchTextBox.Text))
                    allCountriesListBox.Items.Add(items[i]);
            }
        }

        private void allCountriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (Country country in avl.GetEnumerator())
            {
                if (country.Name == allCountriesListBox.SelectedItem.ToString())
                {
                    Form2 f = new Form2(country);
                    f.ShowDialog();
                }
            }
        }

        private void biggestPotentialButton_Click(object sender, EventArgs e)
        {
            float potentialTrade = 0;
            biggestPotentialLabel.Text = potentialTrade.ToString();
        }

        private void inOrderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            items.Clear();
            for (int i = 0; i < allCountriesListBox.Items.Count; i++)
            {
                items.Add(allCountriesListBox.Items[i].ToString());
            }
            items.Sort();
            allCountriesListBox.Items.Clear();
            for(int i=0;i<items.Count; i++)
            {
                allCountriesListBox.Items.Add(items[i]);
            }
        }
    }
}
