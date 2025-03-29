using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace ZadElMuslim
{
    class AzkarDB
    {
        readonly SQLiteConnection _connection;

        public AzkarDB(string dbPath)
        {
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<Azkar>();
        }
        public List<Azkar> GetAzkar()
        {
            return (from t in _connection.Table<Azkar>()
                    select t).ToList();
        }
        public List<Azkar> Favourite()
        {
            List<Azkar> q = _connection.Query<Azkar>($"select * from  Azkar where isfavourite=1");
            return q;
        }
        public string Favourise(int id)
        {
            Azkar query = (from t in _connection.Table<Azkar>()
                           where t.id == id
                           select t).SingleOrDefault();
            string Message;
            if (query.isfavourite == true)
            {
                _connection.Query<Azkar>($"update Azkar set isfavourite=0 where id=" + id);
                Message = "إضافة الي المفضلة";

            }
            else
            {
                _connection.Query<Azkar>($"update Azkar set isfavourite=1 where id=" + id);
                Message = "حذف من  المفضلة";
            }
            return Message;
        }
        public string addtasbih(int id)
        {
            Azkar query = (from t in _connection.Table<Azkar>()
                           where t.id == id
                           select t).SingleOrDefault();
            int tasbih = query.tasb + 1;
            _connection.Query<Azkar>($"update Azkar set tasb='{tasbih}' where id=" + id);
            return " عدد مرات التسبيح" + " " + tasbih;

        }
        public string resettasbih(int id)
        {
            Azkar query = (from t in _connection.Table<Azkar>()
                           where t.id == id
                           select t).SingleOrDefault();
            _connection.Query<Azkar>($"update Azkar set tasb=0 where id=" + id);
            return " عدد مرات التسبيح" + " " + 0;

        }
        public Azkar GetZikr(int id)
        {
            return (from t in _connection.Table<Azkar>()
                    where t.id == id
                    select t).Single();
        }

        public void DeleteZikr(int id)
        {
            _connection.Delete<Azkar>(id);
        }

        public void AddZikr(Azkar Zikr)
        {
            _connection.Insert(Zikr);
        }
    }
}