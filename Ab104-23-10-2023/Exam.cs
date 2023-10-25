using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_23_10_2023
{
    internal class Exam
    {
        public string Subject { get; set; }
        public double ExamDuration { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }= DateTime.Now;
    }
}
