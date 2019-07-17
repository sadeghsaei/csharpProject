using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesheetRecordSaving
{
    class Record
    {
        public string registrationID { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int ivp_id { get; set; }
        public DateTime date { get; set; }

        public Record(string registrationID, string name, string address, int ivp_id, DateTime date)
        {
            this.registrationID = registrationID;
            this.name = name;
            this.address = address;
            this.ivp_id = ivp_id;
            this.date = date;
        }

        public Record()
        {
        }

        public override string ToString()

        {
            return "RegistrationID: " + registrationID + ", name: " + name + ", address: " + address + ", date: " + date.ToString();
        }

    }
}
