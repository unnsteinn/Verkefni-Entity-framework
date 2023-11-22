using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni_Entity_framework.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public List<Teacher> Teachers { get; set;} = new List<Teacher>();
    }
}
