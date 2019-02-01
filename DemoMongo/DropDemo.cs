using MongoDB.Bson;
using MongoDB.Driver;

namespace DemoMongo
{
    public class DropDemo
    {
        public static void main()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("csharp_demo_db");
            #region Drop Collection
            db.DropCollection("products");
            #endregion

        }

    }
}
