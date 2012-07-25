using System;
using System.Collections.Generic;
using Eloqua.Api.Rest.Client.Models.Data.Contacts;
using NUnit.Framework;

namespace Eloqua.Api.Rest.Client.Tests.Clients.Data
{
    [TestFixture]
    public class ContactClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password");
        }

        [Test]
        public void GetContactTest()
        {
            const int originalId = 1;
            var contact = _client.Data.Contact.Get(originalId);

            Assert.AreEqual(originalId, contact.id);
        }

        [Test]
        public void SearchContactTest()
        {
            var result = _client.Data.Contact.Get("*", 1, 1);
            Assert.AreEqual(1, result.elements.Count);
        }

        [Test]
        public void CreateContactTest()
        {
            Contact contact = new Contact
                                  {
                                      id = -500002,
                                      firstName = "sample",
                                      lastName = "test",
                                      emailAddress = "sample@test.com"
                                  };

            Contact returnedContact = _client.Data.Contact.Post(contact);

            Assert.AreEqual(contact.emailAddress, returnedContact.emailAddress);
        }

        [Test]
        public void CustomFieldValues()
        {
            var contactView = _client.Assets.ContactView.Get(100001);

            var selectedFields = new Dictionary<int?, string>();
            foreach (var item in contactView.fields)
            {
                selectedFields.Add(item.id, item.name);
            }

            var contactData = _client.Data.Contact.Get("*", 1, 1);
            var contact = contactData.elements[0];


            var contactCustomFields = new Dictionary<int?, string>();
            foreach (var item in contact.fieldValues)
            {
                contactCustomFields.Add(item.id, item.value);
            }

            var fieldValues = new Dictionary<string, string>();
            foreach (var fieldData in contact.fieldValues)
            {
                if (selectedFields.ContainsKey(fieldData.id))
                    fieldValues.Add(selectedFields[fieldData.id], contactCustomFields[fieldData.id]);
            }

            Console.WriteLine("Email Address : " + contact.emailAddress);

            foreach (var item in fieldValues)
            {
                Console.WriteLine(string.Format("key : '{0}', value : '{1}'", item.Key, item.Value));
            }
        }
    }
}
