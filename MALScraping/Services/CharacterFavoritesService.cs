using MALScraping.Entities.Favorites;
using MALScraping.Helpers;
using MALScraping.Shared;
using System.Collections.Generic;

namespace MALScraping.Services
{
    public static class CharacterFavoritesService
    {
        public static IEnumerable<CharacterFavoritesEntity> Load(string userName)
        {
            var nodeCollection = NodeCollectionHelper.AdaptFavorites(WebClientService.GetNodeCollection(userName))[5].ChildNodes[3].ChildNodes;

            var characterFavorites = new List<CharacterFavoritesEntity>();

            for (int i = 1; i < nodeCollection.Count; i += 2)
            {
                characterFavorites.Add(new CharacterFavoritesEntity(
                    nodeCollection[i].ChildNodes[3].ChildNodes[1].ChildNodes[0].InnerText,
                    nodeCollection[i].ChildNodes[3].ChildNodes[1].Attributes[0].Value,
                    nodeCollection[i].ChildNodes[3].ChildNodes[4].InnerText.Trim(),
                    $"https://myanimelist.net{nodeCollection[i].ChildNodes[3].ChildNodes[4].ChildNodes[1].Attributes[0].Value}",
                    nodeCollection[i].ChildNodes[1].ChildNodes[1].ChildNodes[0].Attributes[1].Value));
            }

            return characterFavorites;
        }
    }
}
