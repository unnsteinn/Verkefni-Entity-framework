using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni_Entity_framework.Models
{
    public class Mark
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = new Student();
        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = new Subject();

        public DateTime Date { get; set; } = DateTime.Now;

        public int Grade { get; set; }

    }
}
