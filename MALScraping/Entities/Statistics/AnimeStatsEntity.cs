namespace MALScraping.Entities.Statistics
{
    public class AnimeStatsEntity
    {
        public AnimeStatsEntity(string userName, double days, double meanScore, int watching, int completed, int onHold, int dropped, int planToWatch, int totalEntries, int rewatched, int episodes)
        {
            URL = $"https://myanimelist.net/animelist/t{userName}?status=7";

            Days = days;
            MeanScore = meanScore;

            Watching = watching;
            Completed = completed;
            OnHold = onHold;
            Dropped = dropped;
            PlanToWatch = planToWatch;

            TotalEntries = totalEntries;
            Rewatched = rewatched;
            Episodes = episodes;
        }

        public string URL { get; private set; }

        public double Days { get; private set; }
        public double MeanScore { get; private set; }

        public int Watching { get; private set; }
        public int Completed { get; private set; }
        public int OnHold { get; private set; }
        public int Dropped { get; private set; }
        public int PlanToWatch { get; private set; }

        public int TotalEntries { get; private set; }
        public int Rewatched { get; private set; }
        public int Episodes { get; private set; }
    }
}
