using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("news.txt");
            string data = reader.ReadToEnd();
            List<News> news= JsonConvert.DeserializeObject<List<News>>(data);
            reader.Close();
            Console.WriteLine("Done");



        }

        private static void JsonSerial()
        {
            List<News> newsList = new List<News>();
            newsList.Add(new News()
            {
                PubDate = new DateTime(2020, 5, 5),
                Title = "ایران برد",
                Description = "ایران لهستان را برد"
            });
            newsList.Add(new News()
            {
                PubDate = new DateTime(2020, 5, 6),
                Title = "ایران باخت",
                Description = "ایران از برزیل باخت"
            });

            string data = JsonConvert.SerializeObject(newsList);
            StreamWriter writer = new StreamWriter("news.txt");
            writer.Write(data);
            writer.Flush();
            writer.Close();
        }

        private static void XmlDeserial()
        {
            FileStream fileStream = new FileStream("news.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<News>));
            List<News> news = serializer.Deserialize(fileStream) as List<News>;
            fileStream.Close();
        }

        private static void XmlSerial()
        {
            List<News> newsList = new List<News>();
            newsList.Add(new News()
            {
                PubDate = new DateTime(2020, 5, 5),
                Title = "ایران برد",
                Description = "ایران لهستان را برد"
            });
            newsList.Add(new News()
            {
                PubDate = new DateTime(2020, 5, 6),
                Title = "ایران باخت",
                Description = "ایران از برزیل باخت"
            });

            FileStream fileStream = new FileStream("news.xml", FileMode.OpenOrCreate);
            XmlSerializer serializer = new XmlSerializer(typeof(List<News>));
            serializer.Serialize(fileStream, newsList);
            fileStream.Close();
        }
    }
}
