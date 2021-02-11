using MALScraping.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Favorites
{
    [TestClass]
    public class PeopleFavoritesTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves")]
        public void GetPeopleFavoritesOfValidUser(string userName)
        {
            try
            {
                PeopleFavoritesService.Load(userName);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa")]
        public void GetPeopleFavoritesOfInvalidUser(string userName)
        {
            try
            {
                PeopleFavoritesService.Load(userName);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
