using HtmlAgilityPack;
using System;
using System.Net;

namespace MALScraping.Shared
{
    internal static class WebClientService
    {
        internal static HtmlNodeCollection GetNodeCollection(string userName)
        {
            try
            {
                var webClient = new WebClient();

                var webPage = webClient.DownloadString($"https://myanimelist.net/profile/{userName}");

                var htmlDocument = new HtmlDocument();

                htmlDocument.LoadHtml(webPage);

                return htmlDocument.GetElementbyId("content").ChildNodes[1].ChildNodes[3].ChildNodes;
            }
            catch (WebException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
