using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolymentManagementSystem
{
    class Main
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public DateTime dob { get; set; }
        public DateTime doj { get; set; }
        public string projectAssign { get; set; }
        public float salary { get; set; }
        public string designation { get; set; }
        public string workUnder { get; set; }
        public string password { get; set; }
        public bool loginStatus { get; set; }
        public int attendance { get; set; }
        public string error { get; set; }
        public bool error_status = true;
        public string Authnecation
        {
           get
           {
                return $"{ firstName} { lastName}";
            }
        }
        public string AllDetails
        {
            get
            {
                string linechange = Environment.NewLine;
                return $"{"Employee Id =" + id + linechange}{"firstName ="+firstName+linechange} {"lastName =" + lastName+linechange}{"address =" + address+ linechange}{" dob =" + dob+ linechange}{" doj =" + doj+ linechange}{" projectAssign =" + projectAssign+ linechange}{" salary =" + salary+ linechange}{" designation =" + designation+ linechange}{" workUnder =" + workUnder+ linechange}{" attendance =" + attendance+ linechange}";

            }
        }

    }
}
