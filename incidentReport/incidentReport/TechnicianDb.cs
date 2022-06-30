using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IncidentReport
{
    class TechnicianDb
    {
        private const string Dir = "..\\..\\";
        private const string Path = Dir + "Technicians.txt";

        public static List<Technician> GetTechnicians()
        { 
            List<Technician> technicians = new List<Technician>();

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));
            
            while(textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();

                if(row != null)
                {
                    string[] columns = row.Split('|');
                    Technician technician = new Technician
                    {
                        TechId = Convert.ToInt32(columns[0]),
                        Name = columns[1]
                    };
                    technicians.Add(technician);
                }
            }

            textIn.Close();
            return technicians;
        }

    }
}
