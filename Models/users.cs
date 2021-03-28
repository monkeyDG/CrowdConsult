using MongoDB.Bson.Serialization.Attributes;

namespace Adm4379Example.Model {
    public class Users {
        [BsonId][BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string mongo_id { get; set; }
        public string id { get; set; } //this needs to be a string so that we can compare it against the URL query string without type conversion -- NOTE: we aren't using this.... can we delete it? to do later.
        public string name { get; set; }
        public string company { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public string password { get; set; }
        public int case_posts { get; set; }
        public int consult_contributions { get; set; }
    }
}