using RestSharp;
using System;
using System.Collections.Generic;

namespace _01RestAPI
{
    // https://jsonplaceholder.typicode.com/
    // using RestSharphttp: http://restsharp.org/
    // NuGet: RestSharp v106.3.1

    class Program
    {
        static void Main(string[] args)
        {
            // Accessing the server
            var baseUri = "http://jsonplaceholder.typicode.com";

            // there must be a client who is making calls
            var client = new RestClient(baseUri);

            var request = new RestRequest("/posts/{id}", Method.GET);
            request.AddUrlSegment("id", 1);

            // parameters can be specified like this: ?name=value
            // request.AddParameter()

            var post = client.Execute<Post>(request);

            Console.WriteLine($"userId: {post.Data.userId}, id: {post.Data.id}, title: {post.Data.title}, body: {post.Data.body}\n");



            request = new RestRequest("/posts", Method.GET);

            var posts = client.Execute<List<Post>>(request);

            Console.WriteLine($"ListCount: {posts.Data.Count}");


            Console.ReadLine();
        }
    }


    // This json:
    //
    //{
    //"userId": 1,
    //"id": 1,
    //"title": "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
    //"body": "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
    //}
    //
    // will be deserializing here:

    // 1, Copy the result of https://jsonplaceholder.typicode.com/posts/1
    // 2, Edit / Paste special --> Paste JSON As Classes
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }

}
