using System.Collections;
using System.Collections.Generic;
using RentOpsObjects.Model;


namespace RentOpsWebApp.ViewModels
{
    public class AuditLogViewModel
    {
        //collection of logs 
        public IEnumerable<Log>? Logs { get; set; }

        //collection of log types
        public IEnumerable<LogType>? LogTypes { get; set; }

        //collection of sources
        public IEnumerable<Source>? Sources { get; set; }

        //the log object
        public Log? LogObject { get; set; }


        //filtering system variables
        public string? SearchLogType { get; set; }
        public string? SearchSource { get; set; }

        public string? SearchTimestamp { get; set; }

        public string? SearchException { get; set; }

        // pagination properties
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }




    }
}
