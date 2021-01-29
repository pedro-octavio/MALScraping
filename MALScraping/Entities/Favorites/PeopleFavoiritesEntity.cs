namespace MALScraping.Entities.Favorites
{
    public class PeopleFavoiritesEntity
    {
        public PeopleFavoiritesEntity(string name, string url, string image)
        {
            Name = name;
            URL = url;
            Image = image;
        }

        public string Name { get; private set; }
        public string URL { get; private set; }
        public string Image { get; private set; }
    }
}
