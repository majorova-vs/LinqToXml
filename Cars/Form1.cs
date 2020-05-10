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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public XDocument doc;
        static string fileName;


        //процедура, очищает текстовое поле
        public void ClearTextBox(TextBox textBox)
        {
            textBox.Clear();
        }

        //процедура, которая считывает данные из файла
        public void ReadXMLFile(string fileName, TextBox textBox)
        {
            ClearTextBox(textBox);
            //Читаем данные из файла
            doc = XDocument.Load(fileName);

            //Проходим по каждому элементу
            foreach (XElement item in doc.Root.Elements())
            {
                textBox.Text = textBox.Text + item.Name.ToString() + " ";
                //textBox.Text = textBox.Text + '\r' + '\n';
                //Выводим все аттрибуты
                foreach (XAttribute attr in item.Attributes())
                {
                    textBox.Text = textBox.Text + attr + " ";
                    textBox.Text = textBox.Text + '\r' + '\n';
                }
                
                //Названия всех дочерних элементов
                foreach (XElement el in item.Elements())
                {
                    textBox.Text = textBox.Text + el.Name + " " + el.Value + " ";
                    textBox.Text = textBox.Text + '\r' + '\n';
                }
                textBox.Text = textBox.Text + '\r' + '\n';
            }
        }

        public void ReadTXTFile(string fileName, TextBox textBox)
        {
            ClearTextBox(textBox);
            string fileText = System.IO.File.ReadAllText(fileName);
            textBox.Text = fileText;
        }
        public void Filter(Form2 f)
        {
            IEnumerable<XElement> cars;
            cars = from c in Form1.doc.Root.Elements("Car")
                   select c;
            cars = from c in Form1.doc.Root.Elements("Car")
                   where c.Element("BrandCode").Value == ((f.textBox2.TextLength == 0) ? c.Element("BrandCode").Value : f.textBox2.Text) &&
                   c.Element("LastName").Value == ((f.textBox1.TextLength == 0) ? c.Element("LastName").Value : f.textBox1.Text) &&
                   c.Element("BrandName").Value == ((f.textBox3.TextLength == 0) ? c.Element("BrandName").Value : f.textBox3.Text) &&
                   c.Element("Benzine").Value == ((f.textBox4.TextLength == 0) ? c.Element("Benzine").Value : f.textBox4.Text) &&
                   c.Element("Power").Value == ((f.textBox5.TextLength == 0) ? c.Element("Power").Value : f.textBox5.Text)
                   select c;
            WriteOnForm(cars, textBox1);
        }

        //Отображение элеменов XML из указанного списка на указанную форму
        public void WriteOnForm(IEnumerable<XElement> cars, TextBox textBox1)
        {
            textBox1.Clear();
            //textBox1.Text = f.textBox1.Text;

            foreach (XElement item in cars)
            {
                textBox1.Text = textBox1.Text + item.Name.ToString() + " ";
                //textBox.Text = textBox.Text + '\r' + '\n';
                //Выводим все аттрибуты
                foreach (XAttribute attr in item.Attributes())
                {
                    textBox1.Text = textBox1.Text + attr + " ";
                    textBox1.Text = textBox1.Text + '\r' + '\n';
                }
                //Названия всех дочерних элементов
                foreach (XElement el in item.Elements())
                {
                    textBox1.Text = textBox1.Text + el.Name + " " + el.Value + " ";
                    textBox1.Text = textBox1.Text + '\r' + '\n';
                }
                textBox1.Text = textBox1.Text + '\r' + '\n';
            }
        }

        private void xMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialog1.FileName;
            try
            {
                ReadXMLFile(fileName, textBox2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 setFilterForm = new Form2(this);
            setFilterForm.ShowDialog();
            setFilterForm.Owner = this;
            try
            {
                Filter(setFilterForm);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Сначала нужно открыть XML файл");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.textBox1.Text = setFilterForm.textBox1.Text;
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 delValueForm = new Form3();
            delValueForm.ShowDialog();
            delValueForm.Owner = this;
            try
            {
                DeleteValue(delValueForm);
                IEnumerable<XElement> cars = from c in Form1.doc.Root.Elements("Car")
                                             select c;
                WriteOnForm(cars, textBox2);
                textBox2.Clear();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Сначала нужно открыть XML файл");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DeleteValue(Form3 f)
        {
            //Выбираем те элементы, которые будут удалены

            IEnumerable<XElement> cars = doc.Root.Descendants("Car").Where(
                                         t => 
                                         t.Attribute("Id").Value == ((f.textBox9.TextLength == 0) ? t.Attribute("Id").Value : f.textBox9.Text) &&
                                         t.Element("LastName").Value == ((f.textBox1.TextLength == 0) ? t.Element("LastName").Value : f.textBox1.Text) &&
                                         t.Element("BrandCode").Value == ((f.textBox2.TextLength == 0) ? t.Element("BrandCode").Value : f.textBox2.Text) &&
                                         t.Element("BrandName").Value == ((f.textBox3.TextLength == 0) ? t.Element("BrandName").Value : f.textBox3.Text) &&
                                         t.Element("Benzine").Value == ((f.textBox4.TextLength == 0) ? t.Element("Benzine").Value : f.textBox4.Text) &&
                                         t.Element("Power").Value == ((f.textBox5.TextLength == 0) ? t.Element("Power").Value : f.textBox5.Text) &&
                                         t.Element("BenzineMaxVolume").Value == ((f.textBox6.TextLength == 0) ? t.Element("BenzineMaxVolume").Value : f.textBox6.Text) &&
                                         t.Element("ResidueBenzine").Value == ((f.textBox7.TextLength == 0) ? t.Element("ResidueBenzine").Value : f.textBox7.Text) &&
                                         t.Element("OilVolume").Value == ((f.textBox8.TextLength == 0) ? t.Element("OilVolume").Value : f.textBox8.Text)
                                            );
            //Удаляем выбранные элементы
            cars.Remove();
            doc.Save(fileName);
        }

        //private void changeItemToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form3 setFilterForm = new Form3();
        //    setFilterForm.Show();
        //}
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 addValueForm = new Form3();
            addValueForm.ShowDialog();
            addValueForm.Owner = this;
            try
            {
                AddValue(addValueForm);
                IEnumerable<XElement> cars = from c in Form1.doc.Root.Elements("Car")
                                             select c;
                textBox2.Clear();
                WriteOnForm(cars, textBox2);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Сначала нужно открыть XML файл");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        //Добавление новой записи в файл
        public void AddValue(Form3 f)
        {
            //Вычисляем максимальный ИД автомобиля в базе данных
            int maxId = doc.Root.Elements("Car").Max(t => Int32.Parse(t.Attribute("Id").Value));

            XElement car = new XElement("Car", new XAttribute("Id", ++maxId),
                        new XElement("LastName", f.textBox1.Text),
                        new XElement("BrandCode", f.textBox2.Text),
                        new XElement("BrandName", f.textBox3.Text),
                        new XElement("Benzine", f.textBox4.Text),
                        new XElement("Power", f.textBox5.Text),
                        new XElement("BenzineMaxVolume", f.textBox6.Text),
                        new XElement("ResidueBenzine", f.textBox7.Text),
                        new XElement("OilVolume", f.textBox8.Text));
            doc.Root.Add(car);
            doc.Save(fileName);
        }
        //Сохранение файла
        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;
            try
            {
                // сохраняем текст в файл
                System.IO.File.WriteAllText(fileName, textBox2.Text);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tXTFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialog1.FileName;
            try
            {
                ReadTXTFile(fileName, textBox2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
