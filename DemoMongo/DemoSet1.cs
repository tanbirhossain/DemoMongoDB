using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DemoMongo
{
   public class DemoSet1
    {
         //List data
        public static void main()
        {
            MongoClient client = new MongoClient();

            Console.WriteLine("------  Start database hit-------");
            #region List DataBase
            var db_list = client.ListDatabases().ToList();
            
            foreach (var db in db_list)
            {
                
                Console.WriteLine(db.ToJson());
            }
            #endregion

            #region Showing List Collect
            //var collection = client.GetDatabase("demoDb").GetCollection<BsonDocument>("products");
            //var docList = collection.Find(new BsonDocument()).ToList();

            //foreach (var item in docList)
            //{
            //    Console.WriteLine(item.ToJson()); 

            //}
            #endregion


            #region Crete New Collection
            client.GetDatabase("csharp_demo_db").CreateCollection("products");
            #endregion

            Console.ReadKey();

        }
         

    }
}
