using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Accent
{
    public partial class Form2 : Form
    {
        private string myDirectory = Directory.GetCurrentDirectory();
        private XmlDocument MyDoc = null;
        DataTable ProfTable = null;
        DataSet Profiles = null;

        bool N = false;
        public int idnow = 1;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (StreamReader streamreader = new StreamReader(myDirectory + @"\profiles.xml", System.Text.Encoding.Default))
            {
                Profiles = new DataSet();
                Profiles.ReadXml(streamreader, XmlReadMode.Auto);
                ProfTable = Profiles.Tables[0];
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string s = MaxID();
            XmlDocument doc = new XmlDocument();
            doc.Load(myDirectory + @"\profiles.xml");
            
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node["Name"].InnerText;

                if (name.ToLower() == textBox1.Text.ToLower())
                {
                    N = true;
                    idnow = int.Parse(node["id"].InnerText);
                }

            }

            if (N == false)
            {
                StringBuilder MyStringBuilder = new StringBuilder();
                int i = int.Parse(s) + 1;
                idnow = i;
                DataRow datarow = Profiles.Tables[0].NewRow();

                datarow[0] = Convert.ToString(i);
                datarow[1] = textBox1.Text.Trim();
                datarow[2] = 0;
                datarow[3] = 0;


                Profiles.Tables[0].Rows.Add(datarow);

                if (i == 1)
                {
                    Profiles.Tables[0].DefaultView.AllowDelete = true;
                    Profiles.Tables[0].DefaultView.Delete(0);
                }

                textBox1.Text = "";

                MyDoc = new XmlDocument();
                MyDoc.InnerXml = Profiles.GetXml();
                XmlDeclaration xmldeclaration =
                MyDoc.CreateXmlDeclaration("1.0", "windows-1251", "yes");
                MyDoc.InsertBefore(xmldeclaration, MyDoc.DocumentElement);
                MyDoc.Save(myDirectory + @"\profiles.xml");
                Profiles = new DataSet();
                Profiles.ReadXml(myDirectory + @"\profiles.xml", XmlReadMode.Auto);
                ProfTable = Profiles.Tables[0];
            }
            
            this.Close();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string MaxID()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(myDirectory + @"\profiles.xml");
            int p = 0;

            foreach (XmlNode node in doc.DocumentElement)
            {
                int id = int.Parse(node["id"].InnerText);

                if (id > p)
                {
                    p = id;
                }
            }

            return Convert.ToString(p);
        }
    }
}
