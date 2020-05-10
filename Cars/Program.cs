using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cars
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Cars",
                    new XElement("Car", new XAttribute("Id", 101),
                        new XElement("LastName", "Ivanov"),
                        new XElement("BrandCode", 555),
                        new XElement("BrandName", "BMW"),
                        new XElement("Benzine", "A-72"),
                        new XElement("Power", 700),
                        new XElement("BenzineMaxVolume", 2000),
                        new XElement("ResidueBenzine", 1500),
                        new XElement("OilVolume", 1000)),
                    new XElement("Car", new XAttribute("Id", 102),
                        new XElement("LastName", "Petrova"),
                        new XElement("BrandCode", 666),
                        new XElement("BrandName", "Honda"),
                        new XElement("Benzine", "A-91"),
                        new XElement("Power", 400),
                        new XElement("BenzineMaxVolume", 1500),
                        new XElement("ResidueBenzine", 1500),
                        new XElement("OilVolume", 900)),
                    new XElement("Car", new XAttribute("Id", 103),
                        new XElement("LastName", "Smith"),
                        new XElement("BrandCode", 555),
                        new XElement("BrandName", "BMW"),
                        new XElement("Benzine", "B-92"),
                        new XElement("Power", 700),
                        new XElement("BenzineMaxVolume", 2000),
                        new XElement("ResidueBenzine", 2000),
                        new XElement("OilVolume", 950))));
            xmlDocument.Save(@"D:\Programming\C#_Projects\Cars\Cars\Data.xml"); */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
