using System;
using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails;
using Eloqua.Api.Rest.ClientLibrary.Models.Content;
using NUnit.Framework;
using Email = Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Deployment.Email;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class StructuredEmailDeploymentTest
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        [Test]
        public void ListEmailDeployments()
        {
            var deployments = _client.Assets.EmailDeployment.Get("*", 1, 100);
            Assert.Greater(0, deployments.total);
        }

        [Test]
        public void CreateInlineEmailDeployment()
        {
            var contact = new Models.Assets.Emails.Deployment.Contact()
            {
                id = 1,
                emailAddress = "fred.sakr@eloqua.com"
            };

            var contacts = new List<Models.Assets.Emails.Deployment.Contact>
                                                                                                       {
                                             contact
                                         };

            Models.Assets.Emails.Structured.Email email = _client.Assets.StructuredEmail.Get(5219);

            var name = string.Format("unit-test_{0}", Guid.NewGuid());
            var inlineDeployment = new Models.Assets.Emails.Deployment.Structured.EmailInlineDeployment()
            {
                name = name,
                contacts = contacts,
                email = email,
                type = "EmailInlineDeployment"
            };

            var response = _client.Assets.StructuredEmailInlineDeployment.Post(inlineDeployment);
            Assert.AreEqual(name, response.name);
        }
    }
}
