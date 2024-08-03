using MongoDB.Driver;
using mymvcapp.Models;
using Microsoft.Extensions.Options;

namespace mymvcapp.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<MongoDbSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(mongoDbSettings.Value.ConnectionString);
            _database = mongoClient.GetDatabase(mongoDbSettings.Value.DatabaseName);
        }

        public IMongoCollection<AccountModel> Accounts => _database.GetCollection<AccountModel>("account");
    }
}
