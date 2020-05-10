using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cars
{
    public partial class Form2 : Form
    {
        Form1 f;
   
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            f = form1;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter();
            this.Close();

        }

        public void Filter()
        {
            //IEnumerable<XElement> cars = from c in Form1.doc.Root.Elements("Car")
            //                             where c.Element("LastName").Value == Form2.textBox1.Text
            //                             select c;
            

            //foreach (XElement item in cars)
            //{
            //    textBox1.Text = textBox1.Text + item.Name.ToString() + " ";
            //    //textBox.Text = textBox.Text + '\r' + '\n';
            //    //Выводим все аттрибуты
            //    foreach (XAttribute attr in item.Attributes())
            //    {
            //        textBox1.Text = textBox1.Text + attr + " ";
            //        textBox1.Text = textBox1.Text + '\r' + '\n';
            //    }
            //    //Названия всех дочерних элементов
            //    foreach (XElement el in item.Elements())
            //    {
            //        textBox1.Text = textBox1.Text + el.Name + " " + el.Value + " ";
            //        textBox1.Text = textBox1.Text + '\r' + '\n';
            //    }
            //    textBox1.Text = textBox1.Text + '\r' + '\n';
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
