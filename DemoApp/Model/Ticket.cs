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
        public string Description { get; set; }

        public enum Status
        {
            Open, Resolved, Close
        }
        public enum IncidentType { Hardware, Software, Network,Security, Database }

        public enum Priority { High, Medium, Low }




        public string ConvertTypeToString(Type type)
        {
            return type.ToString();
        }

        public Type ConvertStringToType(string typeString)
        {
            return (Type)Enum.Parse(typeof(Type), typeString);
        }
        public string ConvertStatusToString(Status status) 
        { 
            return status.ToString(); 
        }

        public Status ConvertStringToStatus(string statusString)
        {
            return (Status)Enum.Parse(typeof(Status), statusString);
        }

        public string ConvertPriorityToString(Priority priority)
        {
            return priority.ToString();
        }

        public Priority ConvertStringToPriority(string priorityString)
        {
            return (Priority)Enum.Parse(typeof(Priority), priorityString);
        }

    }
}
