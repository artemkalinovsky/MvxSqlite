using MvxSqlite.Models;
using MvvmCross.Plugins.Sqlite;
using SQLite.Net;

namespace MvxSqlite.Services
{
    public class DataService
        : IDataService
    {
        private readonly SQLiteConnection _connection;

        public DataService(IMvxSqliteConnectionFactory factory)
        {
            _connection = factory.GetConnection("data.dat");
            _connection.CreateTable<Item>();
        }

        public void Save(Item item)
        {
            _connection.Insert(item);
        }

        public Item Load()
        {
            return _connection.Table<Item>().FirstOrDefault();
        }
    }
}

