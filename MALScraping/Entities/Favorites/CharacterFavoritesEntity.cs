namespace MALScraping.Entities.Favorites
{
    public class CharacterFavoritesEntity
    {
        public CharacterFavoritesEntity(string name, string uRL, string workURL, string image)
        {
            Name = name;
            URL = uRL;
            WorkURL = workURL;
            Image = image;
        }

        public string Name { get; private set; }
        public string URL { get; private set; }
        public string WorkURL { get; private set; }
        public string Image { get; private set; }
    }
}
