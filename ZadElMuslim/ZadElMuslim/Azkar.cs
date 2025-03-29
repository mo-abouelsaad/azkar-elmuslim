using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ZadElMuslim
{
        public class Azkar
        {
            private int _id;
            [PrimaryKey, AutoIncrement]
            public int id
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
            }
            public string title { get; set; }
            public string body { get; set; }
            public bool isfavourite { get; set; }
            public int tasb { get; set; }
        }
    }