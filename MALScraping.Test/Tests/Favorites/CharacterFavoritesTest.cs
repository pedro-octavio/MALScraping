using MALScraping.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Favorites
{
    [TestClass]
    public class CharacterFavoritesTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves")]
        public void GetCharacterFavoritesOfValidUser(string userName)
        {
            try
            {
                CharacterFavoritesService.Load(userName);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa")]
        public void GetCharacterFavoritesOfInvalidUser(string userName)
        {
            try
            {
                CharacterFavoritesService.Load(userName);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
