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

            #region List Data
            var db_list = client.ListDatabases().ToList();
            foreach (var db in db_list)
            {
                Console.WriteLine(db.ToJson());
            }
            #endregion


            Console.ReadKey();

        }
         

    }
}
