using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Adm4379Example.Model {
        public class Responses {
        public string response_user { get; set; }
        public string response_description { get; set; }
        public long response_datetime { get; set; }
        public bool response_is_best { get; set; }
    }
    public class Cases {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; } //this needs to be a string so that we can compare it against the URL query string without type conversion
        public string user_email{ get; set; }
        public string company { get; set; }
        public string title { get; set; }
        public string country { get; set; }
        public string tags { get; set; }
        public string description { get; set; }
        public long datetime { get; set; }
        public int bounty { get; set; }
        public int num_responses { get; set; } // need to increment this when new response is posted
        public string logo { get; set; }
        public List<Responses> Responses { get; set; }
    }
}