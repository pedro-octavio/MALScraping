namespace MALScraping.Entities.Statistics
{
    public class MangaStatsEntity
    {
        public MangaStatsEntity(string userName, double days, double meanScore, int reading, int completed, int onHold, int droppped, int planToRead, int totalEntries, int reread, int chapters, int volumes)
        {
            URL = $"https://myanimelist.net/mangalist/{userName}?status=7";
            Days = days;
            MeanScore = meanScore;
            Reading = reading;
            Completed = completed;
            OnHold = onHold;
            Droppped = droppped;
            PlanToRead = planToRead;
            TotalEntries = totalEntries;
            Reread = reread;
            Chapters = chapters;
            Volumes = volumes;
        }

        public string URL { get; private set; }

        public double Days { get; private set; }
        public double MeanScore { get; private set; }

        public int Reading { get; private set; }
        public int Completed { get; private set; }
        public int OnHold { get; private set; }
        public int Droppped { get; private set; }
        public int PlanToRead { get; private set; }

        public int TotalEntries { get; private set; }
        public int Reread { get; private set; }
        public int Chapters { get; private set; }
        public int Volumes { get; private set; }
    }
}
