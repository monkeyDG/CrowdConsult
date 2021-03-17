using MongoDB.Bson.Serialization.Attributes;

namespace Adm4379Example.Model {
    public class Cases {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string mongo_id { get; set; }
        public string id { get; set; } //this needs to be a string so that we can compare it against the URL query string without type conversion
        public string user { get; set; }
        public string company { get; set; }
        public string title { get; set; }
        public string country { get; set; }
        public string tags { get; set; }
        public string description { get; set; }
        public long datetime { get; set; }
        public int bounty { get; set; }
        public int num_responses { get; set; }
        public string logo { get; set; }
    }
}