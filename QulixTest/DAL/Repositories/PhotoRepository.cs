using DAL.Interfaces;
using DAL.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace DAL.Repositories
{
    public class PhotoRepository : IPhotoRepository

    {
        private readonly string _connectionString;
        public PhotoRepository(string con)
        {
            _connectionString = con;
        }

        public List<PhotoEntity> List()
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            return db.Query<PhotoEntity>("SELECT * FROM Photo").ToList();
        }

        public PhotoEntity Get(int id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            return db.Query<PhotoEntity>("SELECT * FROM Photo WHERE id = @id", new { id }).FirstOrDefault();
        }

        public void Update(PhotoEntity entity, int id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var sqlQuery = $"UPDATE Photo SET Name = @Name, Url=@Url ,Size=@Size, Price=@Price, Purchases=@Purchases WHERE Name = '{id}'";
            db.Execute(sqlQuery, entity);
        }

        public void SetRating(int id, int rating)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var sqlQuery = $"UPDATE Photo SET Rating = '{rating}' WHERE Name='{id}'";
            db.Execute(sqlQuery);
        }

        public void Delete(int id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var sqlQuery = $"DELETE FROM photo where id='{id}'";
            db.Execute(sqlQuery);
        }
    }
}
