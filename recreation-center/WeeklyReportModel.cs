namespace coursework
{
     public class WeeklyReportModel
    {
        public string WeekDay { get; set; }
        public int TotalVisitors { get; set; }
        public double TotalIncome { get; set; }

        public WeeklyReportModel(string weekDay, int totalVisitors, double totalIncome)
        {
            this.WeekDay = weekDay;
            this.TotalVisitors = totalVisitors;
            this.TotalIncome = totalIncome;
        }


    }
}
