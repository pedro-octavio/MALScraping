using MALScraping.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Statistics
{
    [TestClass]
    public class AnimeStatsTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves")]
        public void GetAnimeStatsOfValidUser(string userName)
        {
            try
            {
                AnimeStatsService.Load(userName);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa")]
        public void GetAnimeStatsOfInvalidUser(string userName)
        {
            try
            {
                AnimeStatsService.Load(userName);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
