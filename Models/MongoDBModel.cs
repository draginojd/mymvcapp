using MongoDB.Driver;
using MongoDB.Bson;

namespace mymvcapp.Models
{
    public class MongoDBModel
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
