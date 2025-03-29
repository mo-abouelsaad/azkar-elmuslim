using SQLite;
using System;


namespace ZadElMuslim
{
    class SqlCon
    {

        public interface ISQLite
        {
            SQLiteConnection GetConnection();
        }
    }
}
