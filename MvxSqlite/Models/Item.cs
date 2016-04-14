using SQLite.Net.Attributes;

namespace MvxSqlite.Models
{
    [Table("Item")]
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int DatabaseId { get; set; }

        public string Value { get; set; }
    }
}

