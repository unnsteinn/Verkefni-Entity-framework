using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkefni_Entity_framework.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public int GroupId { get; set; }
        public Group Group { get; set; } =new Group();

        public List<Mark> Marks { get;} = new List<Mark>(); 
    }
}
