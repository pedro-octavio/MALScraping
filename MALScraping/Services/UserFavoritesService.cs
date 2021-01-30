using HtmlAgilityPack;
using MALScraping.Entities.Favorites;
using MALScraping.Shared;
using System;
using System.Collections.Generic;

namespace MALScraping.Services
{
    public static class UserFavorites
    {
        public static IEnumerable<AnimeFavoritesEntity> LoadAnimes(string userName)
        {
            var nodeCollection = AdaptNodeCollection(WebClientService.GetNodeCollection(userName))[1].ChildNodes[3].ChildNodes;

            var animeFavorites = new List<AnimeFavoritesEntity>();

            for (int i = 1; i < nodeCollection.Count; i += 2)
            {
                var spanMidiaYear = nodeCollection[i].ChildNodes[3].ChildNodes[4].ChildNodes[0].InnerText.Split(";");

                animeFavorites.Add(new AnimeFavoritesEntity(
                    nodeCollection[i].ChildNodes[3].ChildNodes[1].ChildNodes[0].InnerText,
                    spanMidiaYear[0].Replace("&middot", string.Empty).Trim(),
                    Convert.ToInt32(spanMidiaYear[1]),
                    nodeCollection[i].ChildNodes[3].ChildNodes[1].Attributes[0].Value,
                    nodeCollection[i].ChildNodes[1].ChildNodes[1].ChildNodes[0].Attributes[1].Value));
            }

            return animeFavorites;
        }

        private static HtmlNodeCollection AdaptNodeCollection(HtmlNodeCollection nodeCollection)
        {
            if (nodeCollection.Count == 9) return nodeCollection[5].ChildNodes[1].ChildNodes;
            else return nodeCollection[7].ChildNodes[1].ChildNodes;
        }
    }
}
