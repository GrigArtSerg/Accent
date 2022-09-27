using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Accent
{
    public partial class List : Form
    {
        private string myDirectory = Directory.GetCurrentDirectory();
        public List()
        {
            InitializeComponent();
            LoadDicTable();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void LoadDicTable()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(myDirectory + @"\Slova.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string word = node["word"].InnerText;
                int accent = int.Parse(node["accent"].InnerText);
                listBox1.Items.Add(new DicTable(word, accent));
            }
        }
        class DicTable
        {
            
            public string Word { get; private set; }
            public int Accent { get; private set; }

            public DicTable( string word, int accent)
            {
                
                Word = word;
                Accent = accent;
            }
            public override string ToString()
            {
                return Word + " " + Accent;
            }
        }
    }
}
