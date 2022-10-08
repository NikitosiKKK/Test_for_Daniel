using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;
using Dapper;

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
            var photoEntities = db.Query<PhotoEntity>("SELECT * FROM Photo");
            return photoEntities.ToList();
        }

        public PhotoEntity Get(int id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            return db.QuerySingleOrDefault<PhotoEntity>("SELECT * FROM Photo WHERE id = @id", new { id });
        }

        public PhotoEntity Update(PhotoEntity entity)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var sqlQuery = $"UPDATE Photo SET Name = @Name, Url=@Url ,Size=@Size, Price=@Price, Purchases=@Purchases WHERE id = '{entity.Id}'";
            db.Execute(sqlQuery, entity);
            return entity;
        }

        public void Delete(int id)
        {
            using IDbConnection db = new SqlConnection(_connectionString);
            var sqlQuery = $"DELETE FROM photo where id='{id}'";
            db.Execute(sqlQuery);
        }
    }
}