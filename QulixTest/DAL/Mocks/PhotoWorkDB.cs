using DAL.Interfaces;
using DAL.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace DAL.Mocks
{

    public class PhotoWorkDB:IPhotoWorkDB

    {
        string connectionString;
        public PhotoWorkDB(string con)
        {
            connectionString = con;
        }

        public List<PhotoModelDB> GetPhotos()
        {
            List<PhotoModelDB> photos = new List<PhotoModelDB>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return photos = db.Query<PhotoModelDB>("SELECT * FROM Photo").ToList();

            }

        }
        public PhotoModelDB GetPhotoByName(string name)
        {
            using (
                IDbConnection db = new SqlConnection(connectionString))
            {

                return db.Query<PhotoModelDB>("SELECT * FROM Photo WHERE Name = @name", new { name }).FirstOrDefault();

            }
        }
        public void ChangePhotoByName(PhotoModelDB photo, string name)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = $"UPDATE Photo SET Name = @Name, Url=@Url ,Size=@Size, Price=@Price, Purchases=@Purchases WHERE Name = '{name}'";
                db.Execute(sqlQuery, photo);

            }
        }
        public void GetRating(PhotoModelDB photo, string name)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                var sqlQuery = $"UPDATE Photo SET Rating = @Rating WHERE Name='{name}'";
                db.Execute(sqlQuery, photo);
            }
        }
    }
}
