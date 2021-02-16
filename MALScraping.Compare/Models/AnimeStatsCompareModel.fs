namespace MALScraping.Compare.Models

type AnimeStatsCompareModel (days : double, meanScore : double, watching : int, completed : int, onHold : int, dropped : int, planToWatch : int, totalEntries : int, reWatched : int, episodes : int) = class

    member this.User1DaysDiferenceThanUser2 = days
    member this.User1MeanScoreDiferenceThanUser2 = meanScore

    member this.User1WatchingDiferenceThanUser2 = watching
    member this.User1CompletedDiferenceThanUser2 = completed
    member this.User1OnHoldDiferenceThanUser2 = onHold
    member this.User1DroppedDiferenceThanUser2 = dropped
    member this.User1PlanToWatchDiferenceThanUser2 = planToWatch

    member this.User1TotalEntriesDiferenceThanUser2 = totalEntries
    member this.User1RewatchedDiferenceThanUser2 = reWatched
    member this.User1EpisodesDiferenceThanUser2 = episodes

end
