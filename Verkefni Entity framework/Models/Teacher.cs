using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni_Entity_framework.Models
{
    public class Teacher
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;    

        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
