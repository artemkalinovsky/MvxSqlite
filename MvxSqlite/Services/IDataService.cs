using System;
using MvxSqlite.Models;

namespace MvxSqlite.Services
{
    public interface IDataService
    {
        void Save(Item item);

        Item Load();
    }
    
}
