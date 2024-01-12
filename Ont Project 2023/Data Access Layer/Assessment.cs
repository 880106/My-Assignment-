using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Assessment
    {
        public int AssessmentID { get; set; }
        public int StudentLecturerModuleID { get; set; }
        public string DueDate { get; set; }
        public int AssessmentTypeID { get; set; }
        public string AssessmentStatus { get; set; }
    }
}
