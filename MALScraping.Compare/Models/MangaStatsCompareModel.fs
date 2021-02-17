namespace MALScraping.Compare.Models

type MangaStatsCompareModel (days : double, meanScore : double, reading : int, completed : int, onHold : int, dropped : int, planToRead : int, totalEntries : int, reread : int, chapters : int, volumes : int) = class

    member this.User1DaysDiferenceThanUser2 = days
    member this.User1MeanScoreDiferenceThanUser2 = meanScore

    member this.User1ReadingDiferenceThanUser2 = reading
    member this.User1CompletedDiferenceThanUser2 = completed
    member this.User1OnHoldDiferenceThanUser2 = onHold
    member this.User1DroppedDiferenceThanUser2 = dropped
    member this.User1PlanToReadDiferenceThanUser2 = planToRead

    member this.User1TotalEntriesDiferenceThanUser2 = totalEntries
    member this.User1RereadDiferenceThanUser2 = reread
    member this.User1ChaptersDiferenceThanUser2 = chapters
    member this.User1VolumesDiferenceThanUser2 = volumes

end
