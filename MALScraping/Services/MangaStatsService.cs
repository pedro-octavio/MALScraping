using MALScraping.Entities.Statistics;
using MALScraping.Helpers;
using MALScraping.Shared;
using System;

namespace MALScraping.Services
{
    public static class MangaStatsService
    {
        public static MangaStatsEntity Load(string userName)
        {
            var nodeCollection = NodeCollectionHelper.AdaptMangaStats(WebClientService.GetNodeCollection(userName));

            return new MangaStatsEntity(
                userName,
                Convert.ToDouble(nodeCollection[3].ChildNodes[1].ChildNodes[1].InnerText.Replace(".", ",")),
                Convert.ToDouble(nodeCollection[3].ChildNodes[3].ChildNodes[3].InnerText.Replace(".", ",")),
                Convert.ToInt32(nodeCollection[7].ChildNodes[1].ChildNodes[0].ChildNodes[1].InnerText),
                Convert.ToInt32(nodeCollection[7].ChildNodes[1].ChildNodes[1].ChildNodes[1].InnerText),
                Convert.ToInt32(nodeCollection[7].ChildNodes[1].ChildNodes[2].ChildNodes[1].InnerText),
                Convert.ToInt32(nodeCollection[7].ChildNodes[1].ChildNodes[3].ChildNodes[1].InnerText),
                Convert.ToInt32(nodeCollection[7].ChildNodes[1].ChildNodes[4].ChildNodes[1].InnerText),
                Convert.ToInt32(nodeCollection[7].ChildNodes[2].ChildNodes[0].ChildNodes[1].InnerText.Replace(",", "")),
                Convert.ToInt32(nodeCollection[7].ChildNodes[2].ChildNodes[1].ChildNodes[1].InnerText.Replace(",", "")),
                Convert.ToInt32(nodeCollection[7].ChildNodes[2].ChildNodes[2].ChildNodes[1].InnerText.Replace(",", "")),
                Convert.ToInt32(nodeCollection[7].ChildNodes[2].ChildNodes[3].ChildNodes[1].InnerText.Replace(",", "")));
        }
    }
}
