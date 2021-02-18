namespace MALScraping.Compare.Services

open MALScraping.Services

open MALScraping.Compare.Models

type MangaStatsCompareService () = class

    static member Compare (userName1 : string, userName2 : string) : MangaStatsCompareModel =
        
        let user1 = MangaStatsService.Load userName1
        let user2 = MangaStatsService.Load userName2

        let days = user1.Days - user2.Days
        let meanScore = user1.MeanScore - user2.MeanScore

        let reading = user1.Reading - user2.Reading
        let completed = user1.Completed - user2.Completed
        let onHold = user1.OnHold - user2.OnHold
        let dropped = user1.Droppped - user2.Droppped
        let planToRead = user1.PlanToRead - user2.PlanToRead

        let totalEntries = user1.TotalEntries - user2.TotalEntries
        let reread = user1.Reread - user2.Reread
        let chapters = user1.Chapters - user2.Chapters
        let volumes = user1.Volumes - user2.Volumes

        new MangaStatsCompareModel (days, meanScore, reading, completed, onHold, dropped, planToRead, totalEntries, reread, chapters, volumes)

end
