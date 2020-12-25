# osu.API - unnoficial C# osu! api wrapper

# ![osu.API](https://i.imgur.com/B1vvRwf.png)  

This project is WIP and was made cause most availiable C# wrappers are unmantained and I needed something to use in my personal projects.

## Project Structure
The Api is divided on the following namespaces  

- `osu.API.Data` - Containss all data models.  
- `osu.API.Requests` - Contains all requests (E.g. `GetUserRequest`)  
- `osu.API.Client`  - Contains helpers for talking to the api (E.g. `ClientCredentialsGrant`)

## This project targets the `V2` of the api **exclusively**
If need be, support for V1 could be worked later, but thats not currently planned.

To see what requests are currently implemented [click here](apiv2.md)

## Library Usage
```cs
//This will be simplified under osuClient, but thats not currently implemented

//Gets a token from the api
var token = await Authentication.OAuthClientCredentialsAsync(credentials, httpClient);

//Build a Request

//Names of Request classes **are** the canonical name given by the apidocumentation!
GetUserRequest userRequest = new(8945532,Gamemode.Mania, token.Token);

//Execute the request
var user = await userRequest.GetAsync(httpClient);
```

## What is a Request?
A Rquest object is any call to the osu! endpoint,
and a list of those requests are available on the official documentation.
And those can be either authenticated or not.

They are represented by `AuthenticatedRequest<T>` and `BaseRequest<T>` on the lowest levels.
Although you rarely will need to use those abstract classes since 
the project provides `(Get|Post)Request<T>` and `Authenticated(Get|Post)Request<T>`  .  

There's also interfaces for defining URL parameters and Query parameters
to further simplify implementation.

The design as it curently stand is directly translatable from the oficial
documentation. An example of that is provided below:

```
Get User

HTTP Request
GET /users/{user}/{mode?}

URL Parameters
Parameter  Status       Description
user       required	Id of the user.
mode       optional	GameMode. User default mode will be used if not specified.
```
Becomes:
```cs
public class GetUserRequest : AuthenticatedGetRequest<User> {
	public GetUserRequest(UserUrlParam user, string accessToken) : base(accessToken) {
		UrlParameters.Add(user);
	}

	public GetUserRequest(UserUrlParam user, ModeUrlParam mode, string accessToken) : base(accessToken) {
		UrlParameters.Add(user);
		UrlParameters.Add(mode);
	}
}
```

All of the html request handling and response parsing is done by `AuthenticatedGetRequest`.