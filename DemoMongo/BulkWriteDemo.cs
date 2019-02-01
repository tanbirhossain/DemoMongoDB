using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DemoMongo
{
    public class BulkWriteDemo
    {
        public static void main()
        {
            MongoClient client = new MongoClient();
            var collection = client.GetDatabase("csharp_demo_db").GetCollection<BsonDocument>("products");
            #region insert one
            //BsonDocument doc = new BsonDocument();
            //doc.Add("category", "Electronices");
            //doc.Add("name", "Amazon echo");
            //doc.Add("price", 180);

            //collection.InsertOne(doc);
            #endregion


            #region Multiple Insert

            BsonDocument doc1 = new BsonDocument();
            doc1.Add("category", "Electronices");
            doc1.Add("name", "TestName1");
            doc1.Add("price", 33);

            BsonDocument doc2 = new BsonDocument();
            doc2.Add("category", "Electronices");
            doc2.Add("name", "TestName2");
            doc2.Add("price", 99);

            BsonDocument doc3 = new BsonDocument();
            doc3.Add("category", "Electronices");
            doc3.Add("name", "TestName1");
            doc3.Add("price", 10);

            var list_docs = new List<BsonDocument>();
            list_docs.Add(doc1);
            list_docs.Add(doc2);
            list_docs.Add(doc3);

            collection.InsertMany(list_docs);

            #endregion

        }
    }
}