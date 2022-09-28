using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Accent
{
    class Staff
    {
        private static string myDirectory = Directory.GetCurrentDirectory();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string MaxID(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(myDirectory + @"\" + filename);
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
