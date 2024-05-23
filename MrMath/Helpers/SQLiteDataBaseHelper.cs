using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MrMath.Models;

namespace MrMath.Helpers
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _conn; 

        public SQLiteDataBaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Registro>().Wait();
        }

        public Task<int> Insert (Registro r)
        {
            return _conn.InsertAsync(r);
        }

        public Task<List<Registro>> Update (Registro r) 
        {
            string sql = "UPDATE Registro SET Nome=?, Email=?, Data=?, Senha=?";
            return _conn.QueryAsync<Registro>(sql, r.Nome, r.Email, r.Data, r.Senha, r.Id);
        }

        public Task <List<Registro>> GetAll()
        {
            return _conn.Table<Registro>().ToListAsync();
        }

        public Task<int> Delete (int id)
        {
            return _conn.Table<Registro>().DeleteAsync(i => i.Id == id);
        }

    }
}
