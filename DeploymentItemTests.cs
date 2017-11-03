using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeploymentItemTestBug
{
    [TestClass]
    public class DeploymentItemTests
    {
        [TestMethod]
        [DeploymentItem("DeploymentItemTestBug.dll")]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }
    }
}