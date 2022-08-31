using System;
using System.Collections.Generic;
using System.Linq;
using CovidStatistics.Entities;
using CovidStatistics.Helpers;
using CovidStatistics.Models;
using CovidStatistics.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CovidStatistics.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/region")]
    public class RegionController : Controller
    {
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet("cases")]
        public IActionResult GetCases([FromQuery] RegionEnum? region = null,
                                         [FromQuery] DateTime? from = null,
                                         [FromQuery] DateTime? to = null)
        {
            // Validate
            ValidationService validationService = new ValidationService();
            validationService.ValidateDataCases(region, from, to);
            if (validationService.HasErrors())
                return BadRequest(validationService.Errors);

            // Read data
            RegionCasesCsv[] regionCasesCsvList = _regionService.GetRegionCasesCsvList();

            // Filter data by date
            int startIndex = 0;
            int endIndex = regionCasesCsvList.Length;
            if (from != null && DateTime.Compare(from.Value, regionCasesCsvList[0].Date) >= 0)
            {
                RegionCasesCsv fromDateObject = new RegionCasesCsv();
                fromDateObject.Date = from.Value;
                startIndex = Array.BinarySearch(regionCasesCsvList, fromDateObject);
            }
            if (to != null && DateTime.Compare(to.Value, DateTime.Now) < 0)
            {
                RegionCasesCsv toDateObject = new RegionCasesCsv();
                toDateObject.Date = to.Value;
                endIndex = Array.BinarySearch(regionCasesCsvList, toDateObject) + 1;
            }
            RegionCasesCsv[] regionCasesCsvListFilteredByDate = regionCasesCsvList.Skip(startIndex).Take(endIndex - startIndex).ToArray();

            // Map to response object and return
            return Ok(_regionService.RegionCasesCsvToResponse(regionCasesCsvListFilteredByDate, region.Value));
        }

        [HttpGet("lastweek")]
        public IActionResult GetLastWeek()
        {
            // Read data
            RegionCasesCsv[] regionCasesCsvList = _regionService.GetRegionCasesCsvList();
            RegionCasesCsv[] regionCasesLastSevenDays = regionCasesCsvList.Skip(Math.Max(0, regionCasesCsvList.Count() - 7)).ToArray();

            RegionLastweekModel lj = new RegionLastweekModel("Ljubljana");
            RegionLastweekModel ce = new RegionLastweekModel("Celje");
            RegionLastweekModel kr = new RegionLastweekModel("Kranj");
            RegionLastweekModel nm = new RegionLastweekModel("Novo mesto");
            RegionLastweekModel kk = new RegionLastweekModel("Krško");
            RegionLastweekModel kp = new RegionLastweekModel("Koper");
            RegionLastweekModel mb = new RegionLastweekModel("Maribor");
            RegionLastweekModel ms = new RegionLastweekModel("Murska Sobota");
            RegionLastweekModel ng = new RegionLastweekModel("Nova Gorica");
            RegionLastweekModel po = new RegionLastweekModel("Postojna");
            RegionLastweekModel sg = new RegionLastweekModel("Slovenj Gradec");
            RegionLastweekModel za = new RegionLastweekModel("Zagorje");
            foreach (RegionCasesCsv regionCases in regionCasesLastSevenDays)
            {
                lj.sumOfActiveCases += regionCases.LjCasesActive;
                ce.sumOfActiveCases += regionCases.CeCasesActive;
                kr.sumOfActiveCases += regionCases.KrCasesActive;
                nm.sumOfActiveCases += regionCases.NmCasesActive;
                kk.sumOfActiveCases += regionCases.KkCasesActive;
                kp.sumOfActiveCases += regionCases.KpCasesActive;
                mb.sumOfActiveCases += regionCases.MbCasesActive;
                ms.sumOfActiveCases += regionCases.MsCasesActive;
                ng.sumOfActiveCases += regionCases.NgCasesActive;
                po.sumOfActiveCases += regionCases.PoCasesActive;
                sg.sumOfActiveCases += regionCases.SgCasesActive;
                za.sumOfActiveCases += regionCases.ZaCasesActive;
            }
            List<RegionLastweekModel> result = new List<RegionLastweekModel>() { lj, ce, kr, nm, kk, kp, mb, ms, ng, po, sg, za};
            result = result.OrderByDescending(x => x.sumOfActiveCases).ToList();
            return Ok(result);
        }


    }
}
