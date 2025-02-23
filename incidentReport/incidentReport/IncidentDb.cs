﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IncidentReport
{
    class IncidentDb
    {
        private const string Dir = "..\\..\\";
        private const string Path = Dir + "Incidents.txt";

        public static List<Incident> GetIncidents()
        {
            List<Incident> incidents = new List<Incident>();
            StreamReader textIn = new StreamReader(
               new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();

                if (row != null)
                {
                    string[] columns = row.Split('|');
                    Incident incident = new Incident
                    {
                        IncdientsId = Convert.ToInt32(columns[0]),
                        CustomerId = Convert.ToInt32(columns[1]),
                        ProductCode = columns[2]
                    };

                    if (columns[3] == "")
                        incident.TechId = null;
                    else
                        incident.TechId = Convert.ToInt32(columns[3]);

                    incident.DateOpened = Convert.ToDateTime(columns[4]);

                    if (columns[5] == "")
                        incident.DateClosed = null;
                    else
                        incident.DateClosed = Convert.ToDateTime(columns[5]);

                    incident.Title = columns[6];
                    incident.Description = columns[7];

                    incidents.Add(incident);
                }
            }

            textIn.Close();
            return incidents;
        }
    }
}
