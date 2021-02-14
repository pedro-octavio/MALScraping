using MALScraping.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MALScraping.Test.Tests.Statistics
{
    [TestClass]
    public class MangaStatsTest
    {
        [TestMethod]
        [DataRow("AlexandreEsteves")]
        public void GetMangaStatsOfValidUser(string userName)
        {
            try
            {
                MangaStatsService.Load(userName);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        [DataRow("ska01pelxa")]
        public void GetMangaStatsOfInvalidUser(string userName)
        {
            try
            {
                MangaStatsService.Load(userName);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "The remote server returned an error: (404) Not Found.");
            }
        }
    }
}
