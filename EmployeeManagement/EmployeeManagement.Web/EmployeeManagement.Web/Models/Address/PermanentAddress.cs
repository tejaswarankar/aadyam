
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emp.Web.Models.Address
{
    public class PermanentAddress : GenericAttributes<int>
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [ForeignKey("EmployeeModel")]
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
