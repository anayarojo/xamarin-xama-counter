using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace XamaCounter.Models
{
    public class AppState
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool IsLogged { get; set; }
    }
}
