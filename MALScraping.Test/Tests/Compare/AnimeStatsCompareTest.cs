using MALScraping.Compare.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Compare
{
    [TestClass]
    public class AnimeStatsCompareTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves", "leootaco")]
        public void GetAnimeFavoritesOfValidUser(string userName1, string userName2)
        {
            try
            {
                AnimeStatsCompareService.Compare(userName1, userName2);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa", "leootaco")]
        public void GetAnimeFavoritesOfFirstUserInvalid(string userName1, string userName2)
        {
            try
            {
                AnimeStatsCompareService.Compare(userName1, userName2);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }

        [TestMethod]
        [DataRow("AlexandreEsteves", "ska01pelxa")]
        public void GetAnimeFavoritesOfSecondUserInvalid(string userName1, string userName2)
        {
            try
            {
                AnimeStatsCompareService.Compare(userName1, userName2);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
