using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            // Add code here to read the text file into the List<InvItem> object.
            // Read or create the file
            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            // Read the data from the file
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();

                if (row != null)
                {
                    try
                    {
                        string[] columns = row.Split('|');
                        InvItem item = new InvItem
                        {
                            ItemNo = Convert.ToInt32(columns[0]),
                            Description = columns[1],
                            Price = Convert.ToDecimal(columns[2])
                        };
                        items.Add(item);
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                }
            }
            textIn.Close();

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.

            // The BinaryWriter will write the items to the text file specified
            BinaryWriter binaryOut = new BinaryWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (InvItem item in items)
            {
                binaryOut.Write(item.ItemNo);
                binaryOut.Write(item.Description);
                binaryOut.Write(item.Price);
            }
            binaryOut.Close();


        }
    }
}
