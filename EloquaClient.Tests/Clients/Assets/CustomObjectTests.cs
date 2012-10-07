using System;
using System.Collections.Generic;
using Eloqua.Api.Rest.ClientLibrary.Models;
using Eloqua.Api.Rest.ClientLibrary.Models.Assets.CustomObjects;
using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Assets
{
    [TestFixture]
    public class CustomObjectTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password");
        }

        [Test]
        public void GetCustomObjectTest()
        {
            int id = 32;
            var customObject = _client.Assets.CustomObject.Get(id);
            Assert.AreEqual(id, customObject.id);
        }

        [Test]
        public void GetCustomObjectsTest()
        {
            var customObjects = _client.Assets.CustomObject.Get("*", 1, 50);
            Assert.Greater(customObjects.total, 0);
        }

        [Test]
        public void CreateCustomObject()
        {
            var customObject = new CustomObject
                                   {
                                       name = string.Format("test-{0}", Guid.NewGuid()),
                                       fields = new List<CustomObjectField>
                                                    {
                                                        new CustomObjectField
                                                            {
                                                                name = "text field",
                                                                dataType =
                                                                    Enum.GetName(typeof (FieldDataType),
                                                                                 FieldDataType.text),
                                                                displayType =
                                                                    Enum.GetName(typeof (FieldDisplayType),
                                                                                 FieldDisplayType.text),
                                                                type = "CustomObjectField"
                                                            },
                                                        new CustomObjectField
                                                            {
                                                                name = "numeric field",
                                                                dataType =
                                                                    Enum.GetName(typeof (FieldDataType),
                                                                                 FieldDataType.number),
                                                                displayType =
                                                                    Enum.GetName(typeof (FieldDisplayType),
                                                                                 FieldDisplayType.text),
                                                                type = "CustomObjectField"
                                                            },

                                                        new CustomObjectField
                                                            {
                                                                name = "date field",
                                                                dataType =
                                                                    Enum.GetName(typeof (FieldDataType),
                                                                                 FieldDataType.date),
                                                                displayType =
                                                                    Enum.GetName(typeof (FieldDisplayType),
                                                                                 FieldDisplayType.text),
                                                                type = "CustomObjectField"
                                                            }
                                                    }
                                   };

            var response = _client.Assets.CustomObject.Post(customObject);
            Assert.Greater(response.id, 0);
        }

        [Test]
        public void DeleteCustomObject()
        {
            int id = 33;
             _client.Assets.CustomObject.Delete(id);
        }
    }
}
