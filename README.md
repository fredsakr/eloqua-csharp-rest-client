eloqua-csharp-rest-client
=========================

Eloqua C# Rest Client

## Usage

### GET (item)
var client = new Eloqua.Client("site", "user", "pass");

var email = client.Email.Get(1); // integer Id of the Email

### GET (list)
var client = new Eloqua.Client("site", "user", "pass");

var emails = client.Email.Get("searchTerm", pageNumber, pageSize);

### POST
var email = new Email() { ... };

var client = new Eloqua.Client("site", "user", "pass");

var email = client.Email.Post(Email);

### PUT
var email = new Email() { ... };

var client = new Eloqua.Client("site", "user", "pass");

var email = client.Email.Put(Email);

### DELETE
var client = new Eloqua.Client("site", "user", "pass");

var email = client.Email.Delete(1); // integer Id of the Email
