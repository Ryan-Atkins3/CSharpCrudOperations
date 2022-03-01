using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class Item
    {
        private string _name;
        private string _upc;
        private double _storePrice;
        private string _accessKey;
        private double _costPerCase;
        private int _units;
        private string distributor;



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Upc
        {
            get { return _upc; }
            set { _upc = value; }
        }

        public double StorePrice
        {
            get { return _storePrice; }
            set { _storePrice = value; }
        }

        public string AccessKey
        {
            get { return _accessKey; }
            set { _accessKey = value; }
        }

        public double CostPerCase
        {
            get { return _costPerCase; }
            set { _costPerCase = value; }
        }

        public int UnitCount
        {
            get { return _units; }
            set { _units = value; }
        }

        public string Distributor
        {
            get { return distributor; }
            set { distributor = value; }
        }
    }
}
