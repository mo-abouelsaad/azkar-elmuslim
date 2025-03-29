using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace ZadElMuslim
{
    public class LocationDB
    {
        readonly SQLiteConnection _connection;
        public LocationDB(string dbPath)
        {
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<LocationModel>();
        }
        public List<LocationModel> GetLoc()
        {
            return (from t in _connection.Table<LocationModel>()
                    select t).ToList();
        }
        public LocationModel GetlastLoc()
        {
            List<LocationModel> q = _connection.Query<LocationModel>($"select * from  LocationModel limit 1");
            LocationModel l = q.LastOrDefault();
            return l;
        }
        public void AddLoc(LocationModel loc)
        {
            _connection.Insert(loc);
        }
        public void vib(int b)
        {
            _connection.Query<LocationModel>($"update LocationModel set vib={b} where 1");
        }
        public void sound(int b)
        {
            _connection.Query<LocationModel>($"update LocationModel set snd={b} where 1");
        }
        public void nav(int b)
        {
            _connection.Query<LocationModel>($"update LocationModel set nav={b} where 1");
        }
    }
}