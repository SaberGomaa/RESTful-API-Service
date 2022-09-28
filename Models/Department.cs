using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_Servics.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; } 
            = new HashSet<Employee>();
    }
}