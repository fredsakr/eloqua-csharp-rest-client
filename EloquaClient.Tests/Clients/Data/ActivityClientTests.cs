using System;
using Eloqua.Api.Rest.ClientLibrary.Models.Data.Activities;
using NUnit.Framework;

namespace Eloqua.Api.Rest.ClientLibrary.Tests.Clients.Data
{
    [TestFixture]
    public class ActivityClientTests
    {
        private Client _client;

        [TestFixtureSetUp]
        public void Init()
        {
            _client = new Client("site", "user", "password", Constants.BaseUrl);
        }

        #region helpers

        private static long ConvertToUnixEpoch(DateTime date)
        {
            return (long)new TimeSpan(date.Ticks - _unixEpochTime.Ticks).TotalSeconds;
        }
        private static DateTime _unixEpochTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        #endregion

        [Test]
        public void GetActivitiesTest()
        {
            var activities = _client.Data.Activity.Get(380458, ActivityType.emailSend.ToString(), 1000,
                                                       ConvertToUnixEpoch(new DateTime(2012, 01, 01)),
                                                       ConvertToUnixEpoch(new DateTime(2012, 08, 01)), 1);

            Assert.Greater(0, activities.Count);
        }
    }
}
