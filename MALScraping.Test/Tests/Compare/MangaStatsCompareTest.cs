using MALScraping.Compare.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Compare
{
    [TestClass]
    public class MangaStatsCompareTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves", "leootaco")]
        public void GetMangaFavoritesOfValidUser(string userName1, string userName2)
        {
            try
            {
                var x = MangaStatsCompareService.Compare(userName1, userName2);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa", "leootaco")]
        public void GetMangaFavoritesOfFirstUserInvalid(string userName1, string userName2)
        {
            try
            {
                MangaStatsCompareService.Compare(userName1, userName2);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }

        [TestMethod]
        [DataRow("AlexandreEsteves", "ska01pelxa")]
        public void GetMangaFavoritesOfSecondUserInvalid(string userName1, string userName2)
        {
            try
            {
                MangaStatsCompareService.Compare(userName1, userName2);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
