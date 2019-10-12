using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WinApp.Tests
{
    [TestFixture]
    public class WinAppTests
    {
        [Test]
        public void SampleTestMethod()
        {
            //Fake test to be executed by CI/CD tool
            Assert.That(true, Is.True);
        }
    }
}
