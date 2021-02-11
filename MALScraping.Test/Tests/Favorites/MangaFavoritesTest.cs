using MALScraping.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Favorites
{
    [TestClass]
    public class MangaFavoritesTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves")]
        public void GetMangaFavoritesOfValidUser(string userName)
        {
            try
            {
                MangaFavoritesService.Load(userName);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa")]
        public void GetMangaFavoritesOfInvalidUser(string userName)
        {
            try
            {
                MangaFavoritesService.Load(userName);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
