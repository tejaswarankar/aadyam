using Emp.Web.Models.Address;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Emp.Web.Models
{
    public class Employee
    {
        [NotMapped]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CountryCode { get; set; }
        public Int64 ContactNo { get; set; }
        public string EmailId { get; set; }
        public string HighestQualification { get; set; }
        public string TypeOfEmployee { get; set; }
        public string Gender { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        public virtual PermanentAddress PermanentAddressModel { get; set; }
        public List<CurrentAddress> CurrentAddresses { get; set; }
        public List<OfficeAddress> OfficeAddresses { get; set; }

        public List<OtherAddress> OtherAddresses { get; set; }

        public virtual User user { get; set; }
        [NotMapped]
        public virtual CurrentAddress CurrentAddressModel { get; set; }
        [NotMapped]
        public virtual OfficeAddress OfficeAddressModel { get; set; }
    }
}
