using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskWithMVC.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }

        public virtual ICollection<Programmer> Programers { get; set; }
        public Project()
        {
            Programers = new List<Programmer>();
        }

    }
}
