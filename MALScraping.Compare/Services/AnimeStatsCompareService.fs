namespace MALScraping.Compare.Services

open MALScraping.Services

open MALScraping.Compare.Models

type AnimeStatsCompareService () = class

    static member Compare (userName1 : string, userName2 : string) : AnimeStatsCompareModel =

        let user1 = AnimeStatsService.Load userName1
        let user2 = AnimeStatsService.Load userName2

        let days = user1.Days - user2.Days
        let meanScore = user1.MeanScore - user2.MeanScore

        let watching = user1.Watching - user2.Watching
        let completed = user1.Completed - user2.Completed
        let onHold = user1.OnHold - user2.OnHold
        let dropped = user1.Dropped - user2.Dropped
        let planToWatch = user1.PlanToWatch - user2.PlanToWatch

        let totalEntries = user1.TotalEntries - user2.TotalEntries
        let reWatched = user1.Rewatched - user2.Rewatched
        let episodes = user1.Episodes - user2.Episodes

        new AnimeStatsCompareModel (days, meanScore, watching, completed, onHold, dropped, planToWatch, totalEntries, reWatched, episodes)

end
