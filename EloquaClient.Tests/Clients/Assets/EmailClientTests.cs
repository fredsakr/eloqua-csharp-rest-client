using System;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails;
using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class EmailClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password");
        }

        [Test]
        public void GetEmailTest()
        {
            const int originalId = 8;
            var email = _client.Assets.Email.Get(originalId);

            Assert.AreEqual(originalId, email.id);
        }

        [Test]
        public void GetEmailListTest()
        {
            var result = _client.Assets.Email.Get("*", 1, 1);
            Assert.AreEqual(1, result.elements.Count);
        }

        [Test]
        public void PostEmailTest()
        {
            Email email = null;

            try
            {
                var expectedEmail = new Email
                                        {
                                            emailGroupId = 1,
                                            name = string.Format("test-{0}", Guid.NewGuid())
                                        };

                email = _client.Assets.Email.Post(expectedEmail);
                Assert.AreEqual(expectedEmail.name, email.name);
            }
            finally
            {
                if (email != null && email.id > 0)
                {
                    _client.Assets.Email.Delete(email.id);
                }
            }
        }

        [Test]
        public void PutEmailTest()
        {
            Email email = null;

            try
            {
                var expectedEmail = new Email()
                                        {
                                            emailGroupId = 1,
                                            name = string.Format("test-{0}", Guid.NewGuid())
                                        };

                email = _client.Assets.Email.Post(expectedEmail);
                Assert.AreEqual(expectedEmail.name, email.name);

                string updatedName = string.Format("test-{0}", Guid.NewGuid());
                email.name = updatedName;
                email = _client.Assets.Email.Put(email);

                Assert.AreEqual(updatedName, email.name);
            }
            finally 
            {
                if (email != null && email.id > 0)
                {
                    _client.Assets.Email.Delete(email.id);
                }
            }
        }

        [Test]
        public void DeleteEmailTest()
        {
            var emailName = Guid.NewGuid().ToString();
            var email = new Email
                            {
                                name = emailName,
                                emailGroupId = 1
                            };

            email = _client.Assets.Email.Post(email);
            _client.Assets.Email.Delete(email.id);

            var result = _client.Assets.Email.Get(emailName, 1, 1);
            Assert.AreEqual(0, result.elements.Count);
        }
    }
}