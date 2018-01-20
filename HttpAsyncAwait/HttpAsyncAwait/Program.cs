using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections;

namespace AsyncAwait_002
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetRequest("http://www.microsoft.com.");
            PostRequest("https://posttestserver.com/post.php");


            Console.ReadLine();
        }

        async static void GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responce = await client.GetAsync(url))
                {
                    Console.WriteLine(responce.StatusCode);
                    using (HttpContent content = responce.Content)
                    {
                        //string myContent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                        Console.WriteLine(headers);

                    }
                }

            }
        }
        async static void PostRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                {
                   new KeyValuePair<string, string>("query1","roman" ),
                   new KeyValuePair<string, string>("query2","roman2")
            };
                HttpContent contentForPost = new FormUrlEncodedContent(queries);
                using (HttpResponseMessage responce = await client.PostAsync(url, contentForPost))
                {
                    Console.WriteLine(responce.StatusCode);
                    using (HttpContent content = responce.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;
                        Console.WriteLine(myContent);

                    }
                }

            }
        }
    }
}
