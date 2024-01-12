using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class LecturerModule
    {
        public int LecturerModuleID { get; set; }
        public int UserID { get; set; }
        public int ModuleID { get; set; }
        public string Date { get; set; }
        public string ModLecturerStatus { get; set; }
    }
}
