using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolymentManagementSystem
{
    class Result
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int max { get; set; }
        public int min { get; set; }
         public string Auth
        {
            get
            {
                return $"{max}";
      
            }
        }
    }


}
