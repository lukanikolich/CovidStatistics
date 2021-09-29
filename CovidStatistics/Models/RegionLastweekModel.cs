using System;
namespace CovidStatistics.Models
{
    public class RegionLastweekModel
    {
        public string Region { get; set; }
        public int sumOfActiveCases { get; set; }

        public RegionLastweekModel(string region)
        {
            Region = region;
            sumOfActiveCases = 0;
        }
    }
}
