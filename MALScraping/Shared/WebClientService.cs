using HtmlAgilityPack;
using System.Net;

namespace MALScraping.Shared
{
    internal static class WebClientService
    {
        internal static HtmlNodeCollection GetNodeCollection(string userName)
        {
            var webClient = new WebClient();

            var webPage = webClient.DownloadString($"https://myanimelist.net/profile/{userName}");

            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(webPage);

            var nodeCollection = htmlDocument.GetElementbyId("content").ChildNodes[1].ChildNodes[3].ChildNodes;

            switch (nodeCollection.Count)
            {
                case 9: return nodeCollection[1].ChildNodes[3].ChildNodes[1].ChildNodes;
                default: return nodeCollection[3].ChildNodes[3].ChildNodes[1].ChildNodes;
            }
        }
    }
}
