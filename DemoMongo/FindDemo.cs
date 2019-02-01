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
            //BsonDocument doc = new BsonDocument();
            //doc.Add("price", 180); //this is condition
            //List<BsonDocument> list_docs = collection.Find(doc).ToList();
            //foreach (var item in list_docs)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Limit show collection
            //BsonDocument doc = new BsonDocument();
            ////doc.Add("price", 180);
            //List<BsonDocument> list_docs = collection.Find(doc).Limit(3).ToList();
            //foreach (var item in list_docs)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Sorting
            // BsonDocument doc = new BsonDocument();
            // var builder = Builders<BsonDocument>.Sort;
            // var sorting = builder.Ascending("price");

           
            // List<BsonDocument> list_docs = collection.Find(doc).Sort(sorting).Limit(3).ToList();
            // foreach (var item in list_docs)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            #region Projection
            //BsonDocument doc = new BsonDocument();
            //var builder_proj = Builders<BsonDocument>.Projection;
            //var projection_config = builder_proj.Include("price").Include("name").Exclude("_id");
            //List<BsonDocument> list_docs = collection.Find(doc).Project(projection_config).Limit(4).ToList();
            //foreach (var item in list_docs)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Filter
            BsonDocument doc = new BsonDocument();
            var builder_proj = Builders<BsonDocument>.Projection;
            var projection_config = builder_proj.Include("price").Include("name").Exclude("_id");
            var builder_filter = Builders<BsonDocument>.Filter;
            var filter_query = builder_filter.Gt("price", 50);
         
            List<BsonDocument> list_docs = collection.Find(filter_query).Project(projection_config).Limit(4).ToList();
            foreach (var item in list_docs)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
