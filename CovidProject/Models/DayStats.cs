namespace CovidProject.Models
{
    public class DayStats
    {

        public int? date { get; set; } = 0;
            public int? states { get; set; } = 0;
        public int? positive { get; set; } = 0;
        public int? negative { get; set; } = 0;
        public int? pending { get; set; } = 0;
        public int? hospitalizedCurrently { get; set; } = 0;
        public int? hospitalizedCumulative { get; set; } = 0;
        public int? inIcuCurrently { get; set; } = 0;
        public int? inIcuCumulative { get; set; } = 0;
        public int? onVentilatorCurrently { get; set; } = 0;
        public int? onVentilatorCumulative { get; set; } = 0;
        public DateTime? dateChecked { get; set; } = DateTime.Now;
        public int? death { get; set; } = 0;
        public int? hospitalized { get; set; } = 0;
        public int? totalTestResults { get; set; } = 0;
        public DateTime? lastModified { get; set; } = DateTime.Now;
        public object recovered { get; set; } = 0;
        public int? total { get; set; } = 0;
        public int? posNeg { get; set; } = 0;
        public int? deathIncrease { get; set; } = 0;
        public int? hospitalizedIncrease { get; set; } = 0;
        public int? negativeIncrease { get; set; } = 0;
        public int? positiveIncrease { get; set; } = 0;
        public int? totalTestResultsIncrease { get; set; } = 0;
        public string hash { get; set; } = "_";


    }
}
