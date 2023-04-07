using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4thsemprj1.Models
{
    public class CourseModel
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public string MinimumTime { get; set; }
        public string MaximumTime { get; set; }
        public string ActualFee { get; set; }
        public string NO_Of_Student { get; set; }
    }
}
