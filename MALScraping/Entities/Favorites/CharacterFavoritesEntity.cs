namespace MALScraping.Entities.Favorites
{
    public class CharacterFavoritesEntity
    {
        public CharacterFavoritesEntity(string name, string url, string workName, string workURL, string image)
        {
            Name = name;
            URL = url;
            WorkName = workName;
            WorkURL = workURL;
            Image = image;
        }

        public string Name { get; private set; }
        public string URL { get; private set; }
        public string WorkName { get; private set; }
        public string WorkURL { get; private set; }
        public string Image { get; private set; }
    }
}
