using System;
using FileHelpers;

namespace CovidStatistics.Entities
{
    [DelimitedRecord(",")]
    [IgnoreEmptyLines()]
    [IgnoreFirst()]
    public class RegionCasesCsv : IComparable
    {
        [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
        public DateTime Date;
        [FieldNullValue(typeof(int), "0")]
        public int CeCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int CeCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int CeDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int CeVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int CeVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int ForeignCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int ForeignCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int ForeignDeceasedToDate;

        [FieldNullValue(typeof(int), "0")]
        public int KkCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int KkCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KkDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KkVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KkVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int KpCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int KpCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KpDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KpVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KpVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int KrCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int KrCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KrDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KrVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int KrVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int LjCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int LjCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int LjDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int LjVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int LjVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int MbCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int MbCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int MbDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int MbVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int MbVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int MsCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int MsCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int MsDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int MsVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int MsVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int NgCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int NgCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int NgDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int NgVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int NgVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int NmCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int NmCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int NmDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int NmVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int NmVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int PoCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int PoCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int PoDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int PoVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int PoVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int SgCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int SgCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int SgDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int SgVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int SgVaccinated2ndToDate;

        [FieldNullValue(typeof(int), "0")]
        public int UnknownCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int UnknownCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int UnknownDeceasedToDate;

        [FieldNullValue(typeof(int), "0")]
        public int ZaCasesActive;
        [FieldNullValue(typeof(int), "0")]
        public int ZaCasesConfirmedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int ZaDeceasedToDate;
        [FieldNullValue(typeof(int), "0")]
        public int ZaVaccinated1stToDate;
        [FieldNullValue(typeof(int), "0")]
        public int ZaVaccinated2ndToDate;

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            RegionCasesCsv regionCasesCsv = obj as RegionCasesCsv;
            if (regionCasesCsv != null)
                return this.Date.CompareTo(regionCasesCsv.Date);
            else
                throw new ArgumentException("Object in not of type RegionCasesCsv");
        }
    }
}
