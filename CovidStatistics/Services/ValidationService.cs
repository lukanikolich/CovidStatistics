using System;
using System.Collections.Generic;
using CovidStatistics.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CovidStatistics.Services
{
    public class ValidationService : ControllerBase
    {
        public List<string> Errors { get; set; }

        public ValidationService()
        {
            this.Errors = new List<string>();
        }

        public void ValidateDataCases(RegionEnum? region, DateTime? from, DateTime? to)
        {
            if (region == null)
            {
                this.Errors.Add("unvalid region parameter");
            }
            if (from != null && to != null && DateTime.Compare(from.Value, to.Value) > 0)
            {
                this.Errors.Add("from date should be before to date");
            }
        }

        public bool HasErrors()
        {
            return Errors.Count > 0;
        }
    }
}
