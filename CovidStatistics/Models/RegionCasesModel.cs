using System;
namespace CovidStatistics.Models
{
    public class RegionCasesModel
    {
        public DateTime Date { get; set; }
        public string Region { get; set; }
        public int NumberOfActiveCases { get; set; }
        public int NumberOfVaccined1st { get; set; }
        public int NumberOfVaccined2nd { get; set; }
        public int NumberOfVaccined3rd { get; set; }
        public int DeceasedToDate { get; set; }
    }
}
