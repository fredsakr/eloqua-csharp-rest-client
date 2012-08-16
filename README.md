eloqua-csharp-rest-client
=========================

Eloqua C# Rest Client

## Usage

### Create Client
var client = new Eloqua.Api.Rest.ClientLibrary.Client("site", "user", "pass");

### GET (item)
int emailId = 1;

Email email = client.Assets.Email.Get(emailId);

### GET (list)
List&lt;Email&gt; emails = client.Assets.Email.Get("searchTerm", pageNumber, pageSize);

### POST
Email email = new Email() { ... };

email = client.Assets.Email.Post(Email);

### PUT
Email email = new Email() { ... };

email = client.Assets.Email.Put(Email);

### DELETE
int emailId = 1;

client.Assets.Email.Delete(emailId);
