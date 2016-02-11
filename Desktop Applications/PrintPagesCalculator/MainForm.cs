using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPagesCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            string FilPageStr;
            int FilPage = (Int32)num2.Value;
            if (FilPage == 0)
            {
                FilPageStr = "_";
            }
            else
            {
                FilPageStr = FilPage.ToString();
            }
            string Pack1 = "";
            string Pack2 = "";

            int n = (Int32)num1.Value;  //Pages in book
            int s = n / 4;              //4x pages per Sheet
            if (n % 4 != 0) s = s + 1;  //Add 1 Sheet for <4 pages
            int dx = n % 4;             //additional Pages aboth x4 (MODE)
            if (dx == 3)
            {
                Pack1 = FilPageStr + ",1," + (n - 1).ToString() + ",3";
                Pack2 = "2," + n.ToString() + ",4," + (n - 2).ToString();
            }
            if (dx == 2)
            {
                Pack1 = FilPageStr + ",1," + n.ToString() + ",3"; ;
                Pack2 = "2," + FilPageStr + ",4," + (n - 1).ToString();
            }
            if (dx == 1)
            {
                Pack1 = FilPageStr + ",1," + FilPageStr + ",3";
                Pack2 = "2," + FilPageStr + ",4," + n.ToString();
            }
            if (dx == 0)
            {
                Pack1 = n.ToString() + ",1," + (n - 2).ToString() + ",3";
                Pack2 = "2," + (n - 1).ToString() + ",4," + (n - 3).ToString();
            }

            //int i = 0;
            int x1 = 5;
            int n2 = n - 6 + dx;

            while (x1 < n2)
            {
                Pack1 = Pack1 + "," + (n2).ToString() + "," + (x1).ToString();
                Pack2 = Pack2 + "," + (x1 + 1).ToString() + "," + (n2 - 1).ToString();
                x1 = x1 + 2;
                n2 = n2 - 2;
            }

            tb1.Text = Pack1;
            tb2.Text = Pack2;
            lbSheets.Text = s.ToString();

            //if (cbDirect.Checked)
            //{
            //}

        }
    }
}
