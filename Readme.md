Timezone Lookup API
============

Timezone Lookup is a simple tool for looking up timezone data. It returns the timezone name, offset, and more.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Timezone Lookup API](https://apiverve.com/marketplace/api/timezonelookup)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.TimezoneLookup
```

Using the Package Manager:
```
nuget install APIVerve.API.TimezoneLookup
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.TimezoneLookup
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.TimezoneLookup".
5. Click on the APIVerve.API.TimezoneLookup package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the timezonelookup API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Timezone Lookup API documentation is found here: [https://docs.apiverve.com/api/timezonelookup](https://docs.apiverve.com/api/timezonelookup).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Timezone Lookup API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new TimezoneLookupAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new QueryOptions {
  timezone = "America/New_York"
};
```

###### Simple Request

```
var response = apiClient.execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    Console.WriteLine(response);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "timezone": "America/New_York",
    "timezone_offset": -240,
    "date": "2024-05-12",
    "time": "23:34",
    "time24": "23:34:35",
    "time12": "11:34:35 PM",
    "day": "Sunday",
    "month": "May",
    "year": "2024",
    "unix": "1715571275",
    "dst": true,
    "dst_start": "2024-05-12 23:34:35",
    "dst_end": "2024-05-12 23:34:35",
    "dst_name": "EDT"
  }
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the mailboxlayer website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.