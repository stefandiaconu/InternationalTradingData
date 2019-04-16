using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace International_Trading_Data
{
    public partial class Form2 : Form
    {
        Country country;
        LinkedList<string> temp;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Country country)
        {
            InitializeComponent();
            this.country = country;
            countryNameTextBox.Text = country.Name;
            countryGdpGrowthTextBox.Text = country.GdpGrowth;
            countryInflationTextBox.Text = country.Inflation;
            countryTradeBalanceTextBox.Text = country.TradeBalance;
            countryHdiRankingTextBox.Text = country.HdiRanking;
            foreach(string s in country.MainTradePartners)
            {
                countryMainTradePartnersListBox.Items.Add(s);
            }
            temp = new LinkedList<string>();
            foreach (string s in country.MainTradePartners)
            {
                temp.AddFirst(s);
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            float outParse;
            country.Name = countryNameTextBox.Text;
            if (float.TryParse(countryGdpGrowthTextBox.Text, out outParse)
                && float.TryParse(countryInflationTextBox.Text, out outParse)
                && float.TryParse(countryTradeBalanceTextBox.Text, out outParse)
                && float.TryParse(countryHdiRankingTextBox.Text, out outParse))
            {
                country.GdpGrowth = countryGdpGrowthTextBox.Text;
                country.Inflation = countryInflationTextBox.Text;
                country.TradeBalance = countryTradeBalanceTextBox.Text;
                country.HdiRanking = countryHdiRankingTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter numbers only!\n"
                    + "Open window again to edit country informations!");
            }
            LinkedList<string> tradePartners = new LinkedList<string>();
            for (int i = 0; i < countryMainTradePartnersListBox.Items.Count; i++)
            {
                tradePartners.AddFirst(countryMainTradePartnersListBox.Items[i].ToString());
            }
            country.MainTradePartners = tradePartners;
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                if (temp.ElementAt(i).ToString() == countryMainTradePartnersListBox.SelectedItem.ToString())
                    temp.Remove(temp.ElementAt(i));
            }
            countryMainTradePartnersListBox.Items.Clear();
            foreach (string s in temp)
            {
                countryMainTradePartnersListBox.Items.Add(s);
            }
        }
    }
}
