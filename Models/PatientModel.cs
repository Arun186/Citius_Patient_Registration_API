using System;
using System.Collections.Generic;
using System.Text;

namespace PMS_Models
{
    public class PatientModel
    {
        public int PId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public DateTime? Dob { get; set; }
        public string Password { get; set; }
    }
}
