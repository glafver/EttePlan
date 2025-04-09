using System.Xml;
using System;

namespace YourNamespace
{
    static class Program
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../files/gentext.xml");

            XmlNode transUnitNode = doc.SelectSingleNode("//trans-unit[@id='42014']");
            XmlNode targetNode = null;

            if (transUnitNode != null)
            {
                targetNode = transUnitNode.SelectSingleNode("target");
            }

            if (targetNode != null)
            {
                string text = targetNode.InnerText;

                using (StreamWriter writer = new StreamWriter("../../../files/result.txt"))
                {
                    writer.WriteLine(text);
                }
            }

        }
    }
}