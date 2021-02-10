using MALScraping.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Favorites
{
    [TestClass]
    public class AnimeFavoritesTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves")]
        public void GetAnimeFavoritesOfValidUser(string userName)
        {
            try
            {
                AnimeFavoritesService.Load(userName);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa")]
        public void GetAnimeFavoritesOfInvalidUser(string userName)
        {
            try
            {
                AnimeFavoritesService.Load(userName);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
