using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Accent
{
    public partial class Stats : Form
    {
        private string myDirectory = Directory.GetCurrentDirectory();
        public Stats()
        {
            InitializeComponent();
            LoadProfTable();
        }

        private void LoadProfTable()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(myDirectory + @"/profiles.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node["Name"].InnerText;
                int prav = int.Parse(node["Prav"].InnerText);
                int mist = int.Parse(node["Mist"].InnerText);
                listBox1.Items.Add(new ProfTable(name, prav,mist));
            }
        }
        class ProfTable
        {
            public string Name { get; private set; }
            public int Prav { get; private set; }
            public int Mist { get; private set; }

            public ProfTable( string name, int prav,int mist)
            {

               Name = name;
                Prav = prav;
                Mist = mist;
            }
            public override string ToString()
            {
                return Name + "  " + "Выполнил правильно: " + Prav+ "  "+"Совершено ошибок: "+Mist;
            }
        }
    }
}
