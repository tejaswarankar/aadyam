using System;
using System.Collections.Generic;
using System.Text;

namespace Emp.Web.Models
{
    public class GenericAttributes<T>
    {
        public T Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        //public Version RowVersion { get; set; }
    }
}
