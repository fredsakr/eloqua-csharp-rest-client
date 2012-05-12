eloqua-csharp-rest-client
=========================

Eloqua C# Rest Client

## Usage

### Create Client
var client = new Eloqua.Client("site", "user", "pass");

### GET (item)
int emailId = 1;

Email email = client.Email.Get(emailId);

### GET (list)
List<Email> emails = client.Email.Get("searchTerm", pageNumber, pageSize);

### POST
Email email = new Email() { ... };

### PUT
var email = new Email() { ... };

### DELETE
int emailId = 1;

client.Email.Delete(emailId);
