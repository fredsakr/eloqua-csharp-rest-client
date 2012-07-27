using System;
using System.Collections.Generic;
using Eloqua.Api.Rest.Client.Models.Assets.Microsites;
using NUnit.Framework;

namespace Eloqua.Api.Rest.Client.Tests.Clients.Assets
{
    [TestFixture]
    public class MicrositeClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password");
        }

        [Test]
        public void GetMicrositeTest()
        {
            const int originalId = 8;
            var microsite = _client.Assets.Microsite.Get(originalId);

            Assert.AreEqual(originalId, microsite.id);
        }

        [Test]
        public void GetMicrositeListTest()
        {
            var result = _client.Assets.Microsite.Get("*", 1, 1);
            Assert.AreEqual(1, result.elements.Count);
        }

        [Test]
        public void PostMicrositeTest()
        {
            Microsite microsite = null;

            try
            {
                var expectedMicrosite = new Microsite
                {
                    name = "sample",
                    domains = new List<string>{"sample.com"},
                    isSecure = false
                };

                microsite = _client.Assets.Microsite.Post(expectedMicrosite);
                Assert.AreEqual(expectedMicrosite.name, microsite.name);
            }
            finally
            {
                if (microsite != null && microsite.id > 0)
                {
                    _client.Assets.Microsite.Delete(microsite.id);
                }
            }
        }

    }
}
