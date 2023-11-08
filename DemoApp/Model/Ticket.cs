using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public Status TicketStatus;
        public IncidentType Type { get; set; }
        public string IncidentSubject { get; set; }
        public ObjectId Id { get; set; }
        public string Subject { get; set; }
        public Employee User { get; set; }
        public DateTime Date { get; set; }
        public Priority PriorityType { get; set; }
        public DateTime Deadline { get; set; }
        //public string Deadline { get; set; }
        public string Description { get; set; }

        public enum Status
        {
            Open, Resolved, Close
        }
        public enum IncidentType { Hardware, Software, Network,Security, Database }

        public enum Priority { High, Medium, Low }

    }
}
