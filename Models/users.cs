using MongoDB.Bson.Serialization.Attributes;

namespace Adm4379Example.Model {
    public class Users {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string location { get; set; }
        public string password { get; set; }
        public string picture { get; set; }
    }
}