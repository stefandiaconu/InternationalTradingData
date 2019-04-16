using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading_Data
{
    public class Country : IComparable
    {
        string name;
        string gdpGrowth;
        string inflation;
        string tradeBalance;
        string hdiRanking;
        LinkedList<string> mainTradePartners;

        public Country(string name, string gdpGrowth, string inflation, string tradeBalance, string hdiRanking, LinkedList<string> mainTradePartners)
        {
            this.name = name;
            this.gdpGrowth = gdpGrowth;
            this.inflation = inflation;
            this.tradeBalance = tradeBalance;
            this.hdiRanking = hdiRanking;
            this.mainTradePartners = mainTradePartners;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GdpGrowth
        {
            get { return gdpGrowth; }
            set { gdpGrowth = value; }
        }

        public string Inflation
        {
            get { return inflation; }
            set { inflation = value; }
        }

        public string TradeBalance
        {
            get { return tradeBalance; }
            set { tradeBalance = value; }
        }

        public string HdiRanking
        {
            get { return hdiRanking; }
            set { hdiRanking = value; }
        }

        public LinkedList<string> MainTradePartners
        {
            get { return mainTradePartners; }
            set {  mainTradePartners = value; }
        }

        public int CompareTo(object obj)
        {
            Country temp = (Country)obj;
            return name.CompareTo(temp.name);
        }

        public override string ToString()
        {
            return Name+"\n";
        }

    }
}
