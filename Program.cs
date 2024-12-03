using System.Net.Http;

HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("https://www.apple.com");  // This will throw an exception
WriteLine("Apple's home page has {0:N0} bytes.",
response.Content.Headers.ContentLength);