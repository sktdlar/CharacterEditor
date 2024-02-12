using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class CRUD
    {
        public static void CreateUser(Unit user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("322Group");
            var collection = database.GetCollection<Unit>("Users");
            collection.InsertOne(user);
        }
        public static void GetUser(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("322Group");
            var collection = database.GetCollection<Unit>("Users");
            var user = collection.Find(x => x.Name == name).FirstOrDefault();
            if (user != null)
                Console.WriteLine($"{user.Name} {user.Level}");
            else
                Console.WriteLine("Not found");
        }
        public static List<Unit> GetUsers()
        {
            var users = new List<Unit>();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("322Group");
            var collection = database.GetCollection<Unit>("Users");
            users = collection.Aggregate().ToList();
            return users;
        }
        public static void DeleteUser(string name)
        {

        }
        public static void SaveCurrentUser(string name)
        {
            var users = new List<Unit>();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("322Group");
            var collection = database.GetCollection<Unit>("Users");
/*            collection.ReplaceOne(x => x.Name == name, CurrentUnit);*/
        }
    }
}
