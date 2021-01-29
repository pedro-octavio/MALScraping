namespace MALScraping.Entities.Favorites
{
    public class CharactersFavoritesEntity
    {
        public CharactersFavoritesEntity(string name, string midia, int year, string url, string image)
        {
            Name = name;
            Midia = midia;
            Year = year;
            URL = url;
            Image = image;
        }

        public string Name { get; private set; }
        public string Midia { get; private set; }
        public int Year { get; private set; }
        public string URL { get; private set; }
        public string Image { get; private set; }
    }
}
