
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Emp.Web.Models
{
    public class User : GenericAttributes<int>
    {
        public string UserId { get; set; }
        public string password { get; set; }
        public string UserType { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
