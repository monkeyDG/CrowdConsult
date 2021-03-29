using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Adm4379Example.Model;

namespace Adm4379Example.Services {
    public class CountriesService {
        private readonly IMongoCollection<Countries> _countries;
        public CountriesService(CrowdConsultDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _countries = database.GetCollection<Countries>(settings.CountriesCollectionName);
        }
        public Countries Create(Countries countries){
            _countries.InsertOne(countries);
            return countries;
        }
        public List<Countries> GetCountries() {
            return _countries.Find(countries => true).ToList();
        }
        public void Update(Countries countriesUp) {
            _countries.ReplaceOne(countries => countries.mongo_id == countriesUp.mongo_id, countriesUp);
        }
        public void Remove(string id) {
            _countries.DeleteOne(countries => countries.mongo_id == id);
        }
    }
    public class CasesService {
        private readonly IMongoCollection<Cases> _cases;
        public CasesService(CrowdConsultDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _cases = database.GetCollection<Cases>(settings.CasesCollectionName);
        }
        public Cases Create(Cases cases){
            _cases.InsertOne(cases);
            return cases;
        }
        public List<Cases> GetCases() {
            return _cases.Find(cases => true).ToList();
        }
        public void Update(Cases casesUp) {
            _cases.ReplaceOne(cases => cases.id == casesUp.id, casesUp);
        }
        public void addResponse(Responses responseToAppend, string case_id) { //allows us to append to a nested json object
            _cases.UpdateOneAsync(
                Builders<Cases>.Filter.Eq(cases => cases.id, case_id), // filters for the correct case
                Builders<Cases>.Update.Push(cases => cases.Responses, responseToAppend) // appends the new response
            );
        }

        public void Remove(string id) {
            _cases.DeleteOne(cases => cases.id == id);
        }
    }   
    public class UsersService {
        private readonly IMongoCollection<Users> _users;
        public UsersService(CrowdConsultDatabaseSettings settings) {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<Users>(settings.UsersCollectionName);
        }
        public Users Create(Users users){
            _users.InsertOne(users);
            return users;
        }
        public List<Users> GetUsers() {
            return _users.Find(users => true).ToList();
        }
        public void Update(Users usersUp) {
            _users.ReplaceOne(users => users.id == usersUp.id, usersUp);
        }
        public void Remove(string id) {
            _users.DeleteOne(users => users.id == id);
        }
    }   
}