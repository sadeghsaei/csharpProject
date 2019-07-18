using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesheetRecordSaving
{
    class RecordForFile
    {
        public string registrationID { get; set; }
        public string name { get; set; }
        public string place { get; set; }
        public DateTime date { get; set; }

        public RecordForFile(string registrationID, string name, string place, DateTime date)
        {
            this.registrationID = registrationID;
            this.name = name;
            this.place = place;
            this.date = date;
        }

        public RecordForFile()
        {
        }

        public override string ToString()

        {
            return "RegistrationID: " + registrationID + ", name: " + name + ", place: " + place + ", date: " + date.ToString();
        }

    }
}
