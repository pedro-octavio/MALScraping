using HtmlAgilityPack;

namespace MALScraping.Helpers
{
    internal static class NodeCollectionHelper
    {
        internal static HtmlNodeCollection AdaptFavorites(HtmlNodeCollection nodeCollection)
        {
            if (nodeCollection.Count == 9) return nodeCollection[5].ChildNodes[1].ChildNodes;
            else return nodeCollection[7].ChildNodes[1].ChildNodes;
        }

        internal static HtmlNodeCollection AdaptAnimeStats(HtmlNodeCollection nodeCollection)
        {
            if (nodeCollection.Count == 9) return nodeCollection[1].ChildNodes[3].ChildNodes[1].ChildNodes;
            else return nodeCollection[3].ChildNodes[3].ChildNodes[1].ChildNodes;
        }

        internal static HtmlNodeCollection AdaptMangaStats(HtmlNodeCollection nodeCollection)
        {
            if (nodeCollection.Count == 9) return nodeCollection[1].ChildNodes[5].ChildNodes[1].ChildNodes;
            else return nodeCollection[3].ChildNodes[5].ChildNodes[1].ChildNodes;
        }
    }
}
