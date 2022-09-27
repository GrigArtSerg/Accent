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
using System.Xml.Linq;

namespace Accent
{
    public partial class Form1 : Form
    {
        private string myDirectory = Directory.GetCurrentDirectory();
        private XmlDocument MyDoc = null;
   
        DataTable DicTable = null;
        DataSet Dictionary = null;
        DataTable ProfTable = null;
        DataSet Profiles = null;

        int countUnCor = 0, countCor = 0, ID = 1, accent = 0;
        string word;
        string s;
        bool F = false;
        bool Prover = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader streamreader = new StreamReader(myDirectory + @"\Slova.xml", System.Text.Encoding.Default))
            {
                Dictionary = new DataSet();
                Dictionary.ReadXml(streamreader, XmlReadMode.Auto);
                DicTable = Dictionary.Tables[0];
            }
            using (StreamReader streamreader2 = new StreamReader(myDirectory + @"\profiles.xml", System.Text.Encoding.Default))
            {
                Profiles = new DataSet();
                Profiles.ReadXml(streamreader2, XmlReadMode.Auto);
                ProfTable = Profiles.Tables[0];
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (NeWord.Text == "")
            {
                if (NewAccent.Text == "")
                {
                    enter.Text = "Вы ничего не ввели";
                    return;
                }
                enter.Text = "Вы не ввели cлово";
                return;
            }
            if (NewAccent.Text == "")
            {
                enter.Text = "Вы не ввели номер ударного слога";
                return;
            }

            string s = MaxID();

            StringBuilder MyStringBuilder = new StringBuilder();
            int i = int.Parse(s) + 1;
            string conv = NeWord.Text.ToLower();
            DataRow datarow = Dictionary.Tables[0].NewRow();

            datarow[0] = Convert.ToString(i);
            datarow[1] = conv.Trim();
            datarow[2] = NewAccent.Text.Trim();

            Dictionary.Tables[0].Rows.Add(datarow);
            
           if (i == 1)
            {
                Dictionary.Tables[0].DefaultView.AllowDelete = true;
               Dictionary.Tables[0].DefaultView.Delete(0);
           }
            NewAccent.Text = "";
            NeWord.Text = "";


            MyDoc = new XmlDocument();
            MyDoc.InnerXml = Dictionary.GetXml();
            XmlDeclaration xmldeclaration =
            MyDoc.CreateXmlDeclaration("1.0", "windows-1251", "yes");
            MyDoc.InsertBefore(xmldeclaration, MyDoc.DocumentElement);
            MyDoc.Save(myDirectory + @"\Slova.xml");
            Dictionary = new DataSet();
            Dictionary.ReadXml(myDirectory + @"\Slova.xml", XmlReadMode.Auto);
            DicTable = Dictionary.Tables[0];
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            Answer.Text = "Ответить";
            if (Prover == true)
            {

                XmlDocument DDoc = new XmlDocument();
                DDoc.Load(myDirectory + @"\profiles.xml");
                foreach (XmlNode node in DDoc.DocumentElement)
                {
                    if (ID == int.Parse(node["id"].InnerText))
                    {
                        countCor = int.Parse(node["Prav"].InnerText);
                        countUnCor= int.Parse(node["Mist"].InnerText);

                    }
                }


                if (F == false)
                {
                    Choise();
                    F = true;
                }
                else
                {
                    if (AccentAns.Value == accent)
                    {
                        React.Text = "Правильно";
                        Choise();
                        countCor++;
                        AnsText.Text = null;
                    }
                    else
                    {
                        React.Text = "Неправильно.";
                        countUnCor++;
                    }

                    
                    foreach (XmlNode node in DDoc.DocumentElement)
                    {
                        if (ID == int.Parse(node["id"].InnerText))
                        {
                            node["Prav"].InnerText = Convert.ToString(countCor);
                            node["Mist"].InnerText = Convert.ToString(countUnCor);
                        }
                    }

                    DDoc.Save(myDirectory + @"\profiles.xml");
                }
            }
            else
            {

                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
        }

        public   string MaxID()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(myDirectory + @"\Slova.xml");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NeWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.ShowDialog();
        }

        private void AccentAns_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnsText.Text = "Правильный ответ: " +accent;
        }

        public void Choise()
        {
            Random r = new Random();
            int n = r.Next(1, Convert.ToInt16(MaxID()));

            XmlDocument doc = new XmlDocument();
            doc.Load(myDirectory + @"\Slova.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                int id = int.Parse(node["id"].InnerText);
                word = node["word"].InnerText;
                accent = int.Parse(node["accent"].InnerText);

                if (id == n)
                {
                     
                     QWord.Text = word;
                        string word1=word;
                      string alfavit = "ауеоыиэюя";
                      foreach (var i in alfavit)
                      {
                          word1 = word1.Replace(i, '?');
                      }

                      string negative = "бвгджзйклмнпрстфхцчшщъь";
                      foreach (var i in negative)
                      {
                          word1 = word1.Replace(i,'_');

                      }
                     
                    char l = '1';
                    char[] ar = word1.ToCharArray();
                    for (int i = 0; i < ar.Length; i++)
                    {
                        if(ar[i] == '?')
                        {
                            ar[i] = l;
                            l++;
                            ;
                        } 
                    }
                    string word2 = new string(ar);
                    label6.Text = word2;
                   
                    return;
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Answer.Text = "Начать";
            F = false;
            label6.Text = "__?_?";
            QWord.Text = "слово";
            Prover = true;
            this.ID = form2.idnow;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            NewAccent.Clear();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            NeWord.Clear();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e) //отвечает за очистку результатов
        {
            if (Prover == true)
            {
                XmlDocument DDoc = new XmlDocument();
                DDoc.Load(myDirectory + @"\profiles.xml");
                foreach (XmlNode node in DDoc.DocumentElement)
                {
                    if (ID == int.Parse(node["id"].InnerText))
                    {
                        node["Prav"].InnerText = "0";
                        node["Mist"].InnerText = "0";
                    }
                    DDoc.Save(myDirectory + @"\profiles.xml");
                }
            }
            else
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }

            
        }

        private void QWord_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Stats form3 = new Stats();
            form3.ShowDialog();
        }

        
    }
}
