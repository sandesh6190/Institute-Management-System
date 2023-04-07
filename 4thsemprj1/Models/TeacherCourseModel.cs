using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thsemprj1.Models
{
    public class TeacherCourseModel
    {
        public string ID { get; set; }  
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CourseName { get; set; }
        public DateTime Join_Date { get; set; }
    }
}
