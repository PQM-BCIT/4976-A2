using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Report
{
    public class ReportCount
    {
        // Counts of reports with listed attributes
        public int statusOpen { get; set; }
        public int statusClosed { get; set; }
        public int statusReopened { get; set; }

        public int programCrisis { get; set; }
        public int programCourt { get; set; }
        public int programSMART { get; set; }
        public int programDVU { get; set; }
        public int programMCFD { get; set; }

        public int genderFemale { get; set; }
        public int genderMale { get; set; }
        public int genderTrans { get; set; }

        public int ageAdult { get; set; }
        public int ageYouth2 { get; set; }
        public int ageYouth1 { get; set; }
        public int ageChild { get; set; }
        public int ageSenior { get; set; }
    }
}