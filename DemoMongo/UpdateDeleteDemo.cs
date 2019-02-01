using MongoDB.Bson;
using MongoDB.Driver;

namespace DemoMongo
{
    public class UpdateDeleteDemo
    {
        public static void main()
        {
            MongoClient client = new MongoClient();
            var collection = client.GetDatabase("csharp_demo_db").GetCollection<BsonDocument>("products");
            #region Update One
            //// create a filter and set the value

            //var builder_fiter = Builders<BsonDocument>.Filter.Eq("price", 20);
            //var builder_update = Builders<BsonDocument>.Update.Set("price", 30);
            //collection.UpdateOne(builder_fiter, builder_update);
            #endregion

            #region Update Many
            //// create a filter and set the value

            //var builder_fiter = Builders<BsonDocument>.Filter.Eq("price", 180);
            //var builder_update = Builders<BsonDocument>.Update.Set("price", 185);
            //collection.UpdateMany(builder_fiter, builder_update);
            #endregion

            #region Delete one
            ////// create a filter and set the value
            //var builder_fiter_delete = Builders<BsonDocument>.Filter.Eq("price", 20);

            //collection.DeleteOne(builder_fiter_delete);
            #endregion

            #region Delete Many
            //// create a filter and set the value
            var builder_fiter_delete = Builders<BsonDocument>.Filter.Eq("price", 20);

            collection.DeleteMany(builder_fiter_delete);
            #endregion


        }
    }
}
