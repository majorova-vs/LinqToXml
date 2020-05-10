using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        public bool CheckInputValues(string v1)
        {
            bool flag = false;
            double result;
            double res;
            if (double.TryParse(v1, out res) || v1.Length == 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
                result = 0;
            }
            return flag;
        }
    }
}
