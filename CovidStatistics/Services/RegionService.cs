using System.Collections.Generic;
using System.Net;
using CovidStatistics.Entities;
using CovidStatistics.Helpers;
using CovidStatistics.Models;
using FileHelpers;

namespace CovidStatistics.Services
{
    public class RegionService
    {
        public RegionService()
        {
        }

        public static RegionCasesCsv[] GetRegionCasesCsvList()
        {
            // Read file
            string fileName = "region-cases.csv";
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/sledilnik/data/master/csv/region-cases.csv", fileName);
            }

            // Map .csv to array of objects and delete file
            var engine = new FileHelperEngine<RegionCasesCsv>();
            RegionCasesCsv[] regionCasesCsvList = engine.ReadFile(fileName);
            System.IO.File.Delete(fileName);
            return regionCasesCsvList;
        }


        public static List<RegionCasesModel> RegionCasesCsvToResponse(RegionCasesCsv[] regionCasesCsvListFilteredByDate, RegionEnum region)
        {
            List<RegionCasesModel> result = new List<RegionCasesModel>();
            foreach (RegionCasesCsv regionCasesCsv in regionCasesCsvListFilteredByDate)
            {
                RegionCasesModel regionCasesResponse = new RegionCasesModel();
                regionCasesResponse.Date = regionCasesCsv.Date;
                switch (region)
                {
                    case RegionEnum.LJ:
                        regionCasesResponse.Region = "LJ";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.LjCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.LjVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.LjVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.LjDeceasedToDate;
                        break;
                    case RegionEnum.CE:
                        regionCasesResponse.Region = "CE";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.CeCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.CeVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.CeVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.CeDeceasedToDate;
                        break;
                    case RegionEnum.KR:
                        regionCasesResponse.Region = "KR";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.KrCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.KrVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.KrVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.KrDeceasedToDate;
                        break;
                    case RegionEnum.NM:
                        regionCasesResponse.Region = "NM";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.NmCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.NmVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.NmVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.NmDeceasedToDate;
                        break;
                    case RegionEnum.KK:
                        regionCasesResponse.Region = "KK";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.KkCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.KkVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.KkVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.KkDeceasedToDate;
                        break;
                    case RegionEnum.KP:
                        regionCasesResponse.Region = "KP";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.KpCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.KpVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.KpVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.KpDeceasedToDate;
                        break;
                    case RegionEnum.MB:
                        regionCasesResponse.Region = "MB";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.MbCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.MbVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.MbVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.MbDeceasedToDate;
                        break;
                    case RegionEnum.MS:
                        regionCasesResponse.Region = "MS";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.MsCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.MsVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.MsVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.MsDeceasedToDate;
                        break;
                    case RegionEnum.NG:
                        regionCasesResponse.Region = "NG";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.NgCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.NgVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.NgVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.NgDeceasedToDate;
                        break;
                    case RegionEnum.PO:
                        regionCasesResponse.Region = "PO";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.PoCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.PoVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.PoVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.PoDeceasedToDate;
                        break;
                    case RegionEnum.SG:
                        regionCasesResponse.Region = "SG";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.SgCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.SgVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.SgVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.SgDeceasedToDate;
                        break;
                    case RegionEnum.ZA:
                        regionCasesResponse.Region = "ZA";
                        regionCasesResponse.NumberOfActiveCases = regionCasesCsv.ZaCasesActive;
                        regionCasesResponse.NumberOfVaccined1st = regionCasesCsv.ZaVaccinated1stToDate;
                        regionCasesResponse.NumberOfVaccined2nd = regionCasesCsv.ZaVaccinated2ndToDate;
                        regionCasesResponse.DeceasedToDate = regionCasesCsv.ZaDeceasedToDate;
                        break;
                }
                result.Add(regionCasesResponse);
            }
            return result;
        }
    }
}
