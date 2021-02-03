using MALScraping.Entities.Favorites;
using MALScraping.Helpers;
using MALScraping.Shared;
using System.Collections.Generic;

namespace MALScraping.Services
{
    public static class PeopleFavoritesService
    {
        public static IEnumerable<PeopleFavoritesEntity> Load(string userName)
        {
            var nodeCollection = NodeCollectionHelper.AdaptFavorites(WebClientService.GetNodeCollection(userName))[7].ChildNodes[3].ChildNodes;

            var peopleFavorites = new List<PeopleFavoritesEntity>();

            for (int i = 1; i < nodeCollection.Count; i += 2)
            {
                peopleFavorites.Add(new PeopleFavoritesEntity(
                    nodeCollection[i].ChildNodes[3].ChildNodes[1].InnerText,
                    nodeCollection[i].ChildNodes[3].ChildNodes[1].Attributes[0].Value,
                    nodeCollection[i].ChildNodes[1].ChildNodes[1].ChildNodes[0].Attributes[1].Value));
            }

            return peopleFavorites;
        }
    }
}
