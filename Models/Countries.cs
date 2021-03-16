using MongoDB.Bson.Serialization.Attributes;

namespace Adm4379Example.Model {
    public class Countries {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string mongo_id { get; set; }
        public string country_code { get; set; }
        public string name { get; set; }
    }
}