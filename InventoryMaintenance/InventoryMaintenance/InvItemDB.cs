using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        //private const string Path = @"..\..\InventoryItems.txt";
        private const string Dir = "..\\..\\";
        private const string Path = Dir + "InventoryItems.txt";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();
            XmlReaderSettings settings = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreWhitespace = true
            };

            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // Add code here to read the text file into the List<InvItem> object.
            if (xmlIn.ReadToDescendant("Item"))
            {
                do
                {
                    InvItem item = new InvItem();
                    xmlIn.ReadStartElement("Item");
                    item.ItemNo = xmlIn.ReadElementContentAsInt();
                    item.Description = xmlIn.ReadElementContentAsString();
                    item.Price = xmlIn.ReadElementContentAsDecimal();
                    items.Add(item);
                }
                while (xmlIn.ReadToNextSibling("Item"));
            }

            xmlIn.Close();

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            XmlWriter xmlOut = XmlWriter.Create(Path, settings);
            
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Items");

            foreach (InvItem item in items)
            {
                xmlOut.WriteStartElement("Items");
                xmlOut.WriteStartElement("ItemsNo", Convert.ToString(item.ItemNo));
                xmlOut.WriteStartElement("Description", item.Description);
                xmlOut.WriteElementString("Price", Convert.ToString(item.Price));
                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();
            xmlOut.Close();
        }
    }
}
