using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject_Programming2_V1
{
    class CustomerClass
    {
        // CustomerClass Fields.
        private string customerID, cusName, cusCity, cusCountry;

        public CustomerClass()
        {

        }
        

        // Getters and setters for CustomerClass
        public string gsCustomerID { get => customerID; set => customerID = value; }
        public string gsCusName { get => cusName; set => cusName = value; }
        public string gsCusCity { get => cusCity; set => cusCity = value; }
        public string gsCusCountry { get => cusCountry; set => cusCountry = value; }
       
    }
}
