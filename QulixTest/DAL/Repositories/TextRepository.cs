using DAL.Interfaces;
using DAL.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TextRepository : ITextRepository
    {
        private readonly string _connectionString;
        public TextRepository(string con)
        {
            _connectionString = con;
        }
        public List<TextEntity> GetAllText()
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            return db.Query<TextEntity>("SELECT * FROM Text").ToList();
        }
    }
}
