using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoMongo
{
    public class FindDemo
    {
        public static void main()
        {
            MongoClient client = new MongoClient();
            var collection = client.GetDatabase("csharp_demo_db").GetCollection<BsonDocument>("products");

            #region Find list collection
            //BsonDocument doc = new BsonDocument();
            //List<BsonDocument> list_docs = collection.Find(doc).ToList();
            //foreach (var item in list_docs)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Find With query Collection
            BsonDocument doc = new BsonDocument();
            doc.Add("price", 180);
            List<BsonDocument> list_docs = collection.Find(doc).ToList();
            foreach (var item in list_docs)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
