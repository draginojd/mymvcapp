using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace mymvcapp.Models
{
        public class AccountModel
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }  // Use string for ObjectId compatibility

            [Required]
            [BsonElement("firstName")]
            public string FirstName { get; set; }

            [BsonElement("lastName")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]
            [BsonElement("email")]
            public string Email { get; set; }

            [Required]
            [BsonElement("password")]
            public string Password { get; set; }
        }
    }

// /register/account