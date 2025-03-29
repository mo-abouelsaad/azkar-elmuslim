using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ZadElMuslim
{
   public class FontModel
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Android { get; set; }
        public string IOS { get; set; }
        public bool Active { get; set; }
        public string size { get; set; }
    }
}
