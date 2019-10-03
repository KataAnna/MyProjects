using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskWithMVC.Models
{
    public class Programmer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public Programmer()
        {
            Projects = new List<Project>();
        }
    }
}

