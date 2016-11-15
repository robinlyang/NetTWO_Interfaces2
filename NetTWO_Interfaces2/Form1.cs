using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTWO_Interfaces2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock.StockQuote s = new stock.StockQuote();
            string prices = s.GetQuote(textBox1.Text.ToUpper());
            MessageBox.Show(prices);
        }
    }
    //with Window Forms put any new classes below the Form class or else visual studio will complain
    class databaseClass
    {
        public string key;
        public string name;
        public double salary;
    }
    class mydictionary : IList<databaseClass>
    {
        public databaseClass this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(databaseClass item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(databaseClass item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(databaseClass[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<databaseClass> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(databaseClass item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, databaseClass item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(databaseClass item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
