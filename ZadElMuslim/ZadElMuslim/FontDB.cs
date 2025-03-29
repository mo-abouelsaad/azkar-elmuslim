using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace ZadElMuslim
{
    public class FontDB
    {
        readonly SQLiteConnection _connection;

        public FontDB(string dbPath)
        {
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<FontModel>();
        }

        public List<FontModel> GetFonts()
        {
            return (from t in _connection.Table<FontModel>()
                    select t).ToList();
        }

        public FontModel GetActiveFont()
        {
            return _connection.Table<FontModel>().FirstOrDefault(t => t.Active == true);
        }
        public FontModel GetFont(int id)
        {
            return (from t in _connection.Table<FontModel>()
                    where t.id == id
                    select t).Single();
        }

        public void SetActiveFont(int id)
        {
            int fontid = id + 1;
            var x = _connection.Query<FontModel>($"update FontModel set Active=0 where 1");
            var y = _connection.Query<FontModel>($"update FontModel set Active=1 where id={fontid}");
        }
        public void Setsize(int size)
        {
            _connection.Query<FontModel>($"update FontModel set size={size} where 1");
        }

        public void DeleteFont(int id)
        {
            _connection.Delete<FontModel>(id);
        }

        public void AddFont(FontModel Zikr)
        {
            _connection.Insert(Zikr);
        }
    }
}