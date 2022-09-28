using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson;
using MongoDB.Driver;

namespace RealTimeGameWinForms
{
    internal class MongoDB
    {
        public void AddToDB(Unit unit)
        {
            var un1t = new MongoClient();
            var database = un1t.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            collection.InsertOne(unit);
        }
    }
}
