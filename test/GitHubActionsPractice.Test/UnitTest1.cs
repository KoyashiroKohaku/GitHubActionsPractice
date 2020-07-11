using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KoyashiroKohaku.GitHubActionsPractice.Test
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void GetHellowWorldTest()
        {
            Assert.AreEqual("Hello World!", Program.GetHellowWorld());
        }

        [TestMethod]
        public void GetCurrentTimeTest()
        {
            var timeSpan = Program.GetCurrentTime() - DateTime.Now;
            Assert.IsTrue(-10 < timeSpan.Seconds && timeSpan.Seconds < 10);
        }
    }
}
