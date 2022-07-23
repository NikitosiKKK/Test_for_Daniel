using DAL.Interfaces;
using DAL.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mocks
{
    public class TextWorkDB:ITextWorkDB
    {
        string connectionString;
        public TextWorkDB(string con)
        {
            connectionString = con;
        }
        public List<TextModelDB> GetAllText()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<TextModelDB>("SELECT * FROM Text").ToList();
            }
        }
    }
}
