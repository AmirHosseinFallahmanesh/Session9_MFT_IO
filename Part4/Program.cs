using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            var resut= JsonConvert.DeserializeObject<List<UserModel>>(json);
            foreach (var item in resut)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Completed);
                Console.WriteLine("***********************");
            }
            Console.ReadKey();
        }
    }
    public class UserModel {

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

    }

}
