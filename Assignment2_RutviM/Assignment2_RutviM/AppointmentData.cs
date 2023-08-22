
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_RutviM
{
    public class AppointmentData
    {
        // Properties for storing appointment data
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string provinceCode { get; set; }
        public string PostalCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string MakeAndModel { get; set; }
        public string Year { get; set; }
        public DateTime AppointmentDate { get; set; }
        public object Problem { get; set; }

        // Constructor to initialize the appointment data with default values
        public AppointmentData()
        {
            CustomerName = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            provinceCode = string.Empty;
            PostalCode = string.Empty;
            HomePhone = string.Empty;
            CellPhone = string.Empty;
            Email = string.Empty;
            MakeAndModel = string.Empty;
            Year = string.Empty;
            AppointmentDate = DateTime.Now;
            Problem = string.Empty;
        }
    }
}
