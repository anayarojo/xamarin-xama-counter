using SQLite;

namespace XamaCounter.Data.Models
{
    public class Session
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool IsLogged { get; set; }
    }
}