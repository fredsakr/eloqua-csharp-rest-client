using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients
{
    [TestFixture]
    public class AccountInfoTests
    {
        [Test]
        public void SearchContentSectionTest()
        {
            var accountInfo = Client.GetAccountInfo("site", "user", "password");
            Assert.That(accountInfo, Is.Not.Null);
        }
    }
}