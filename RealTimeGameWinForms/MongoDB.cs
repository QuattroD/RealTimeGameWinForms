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

        public void FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                MessageBox.Show($"Имя - {item?.name} \nЗдоровье - {item?.health} \nМакс.Здоровье - {item?.MaxHealth} \nБроня - {item?.armor} \nУрон - {item?.damage} \nМаг.Урон - {item?.magicdamage} \nМана - {item?.manapool}", "Юнит найден");
            }
        }

        public void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Army");
            var collection = database.GetCollection<Unit>("Units");
            var one = collection.Find(x => x.name == name).FirstOrDefault();

            MessageBox.Show($"Имя - {one?.name} \nЗдоровье - {one?.health} \nМакс.Здоровье - {one?.MaxHealth} \nБроня - {one?.armor} \nУрон - {one?.damage} \nМаг.Урон - {one?.magicdamage} \nМана - {one?.manapool}", "Юнит найден");
        }
    }
}
