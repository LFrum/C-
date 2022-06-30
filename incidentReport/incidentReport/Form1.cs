using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncidentReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Technician> technicianList = TechnicianDb.GetTechnicians();
            List<Incident> incidentList = IncidentDb.GetIncidents();

            var incidents = from incident in incidentList
                            join technician in technicianList
                            on incident.TechId equals technician.TechId
                            where incident.DateClosed != null
                            orderby technician.Name, incident.DateOpened
                            select new
                            {
                                technician.Name,
                                incident.ProductCode,
                                incident.DateOpened,
                                incident.DateClosed,
                                incident.Title
                            };
            string techName = "";
            int i = 0;
            foreach (var incident in incidents)
            {
                if (incident.Name != techName)
                {
                    lvIncidents.Items.Add(incident.Name);
                    techName = incident.Name;
                }
                else
                {
                    lvIncidents.Items.Add("");
                }

                lvIncidents.Items[i].SubItems.Add(incident.ProductCode);
                lvIncidents.Items[i].SubItems.Add(Convert.ToDateTime(incident.DateOpened).ToShortDateString);
                lvIncidents.Items[i].SubItems.Add(Convert.ToDateTime(incident.DateClosed).ToShortDateString);
                lvIncidents.Items[i].SubItems.Add(incident.Title);
                i += i;

            }
        }
        }
    }
}
