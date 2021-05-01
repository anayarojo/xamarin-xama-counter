using SQLite;

namespace XamaCounter.Data.Models
{
    public class AppState
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool IsLogged { get; set; }
    }
}