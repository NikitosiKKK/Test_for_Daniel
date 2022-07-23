using System;
using System.Data.SqlClient;
using System.Threading;

namespace Endpoins.Models
{
    public class DBCreation
    {

        string connectionString = "Data source=NIKITOSRAZVEDOS;Integrated Security=True";


        public void CreateDB()
        {
            SqlConnection db = new SqlConnection(connectionString);

            db.Open();

            SqlCommand command0 = new SqlCommand("CREATE DATABASE qulixtestdb", db);
            command0.ExecuteNonQuery();
            db.Close();
            connectionString = "Data source=NIKITOSRAZVEDOS; Initial Catalog=qulixtestdb;Integrated Security=True";
            db = new SqlConnection(connectionString);
            db.Open();
            SqlCommand command1 = new SqlCommand("CREATE TABLE author (id int NOT NULL IDENTITY(1,1) PRIMARY KEY, name varchar(30), nikname varchar(30), old int, mydate DATETIME NOT NULL DEFAULT getdate())", db);
            SqlCommand command2 = new SqlCommand("CREATE TABLE photo (Authorid int FOREIGN KEY REFERENCES author(id), Name varchar(30), Url varchar(1000), Size varchar(30), Date DATETIME NOT NULL DEFAULT getdate(), Price int, Purchases int, Rating int not null)", db);
            SqlCommand command3 = new SqlCommand("CREATE TABLE text (Authorid int FOREIGN KEY REFERENCES author(id), Name varchar(100), Content varchar(100), Size varchar(30), Date DATETIME NOT NULL DEFAULT getdate(), Price int, Purchases int, Rating int not null)", db);
            SqlCommand command4 = new SqlCommand("INSERT INTO author (name, nikname, old) VALUES('Ivam Sergeevich','Kozar', '29'), ('Nikita Sergeevich', 'Rentgen', '23'), ('Karina Kaptur', 'Karikap', '20'), ('Elena Nikolaevna', 'Elesuk', '24')", db);
            SqlCommand command5 = new SqlCommand("INSERT INTO photo (Authorid, Name, Url, Size, Price, Purchases, Rating) VALUES('2','Driving Renera', 'https://art-storona.ru/wp-content/uploads/2015/03/2009-1-12-1m.jpg','1,72 m x 2,78 m','250','20','0'), ('1','Lona Miza', 'https://content1.rozetka.com.ua/goods/images/big/181734931.jpg','77 sm x 53 sm','500','598592','0'),('1','Borning of Sadam', 'https://www.medswiss.ru/upload/medialibrary/5b9/5b9305d66b0912adbb3db43728997436.png','2,8 m x 5,7 m','550','231','0'),('3','The girl with mashka', 'https://s11.stc.yc.kpcdn.net/share/i/12/11046914/wr-960.webp','44 sm x 39 sm','100','2490','0'),('3','Buad Slack', 'https://www.theartnewspaper.ru/media/original_images/0f770400-3dac-4bea-ad40-44c13e478f83.jpg','80 sm x 80 sm','1','0','0'),('1','Maercs', 'https://cdnn21.img.ria.ru/images/57145/75/571457532_0:155:566:721_1920x0_80_0_0_7401411e5b3308b61650379c7f5939fb.jpg','70 sm x 90 sm','560','514','0')", db);
            SqlCommand command6 = new SqlCommand("INSERT INTO text (Authorid, Name, Content, Size, Price, Purchases, Rating) VALUES('1','Came from a water dry', 'Coock book','1 tom','50','100','0'), ('2','How to run from Bear Greels', 'Survival lessons for insects','205 pages','1','1000000000','0'),('3','Give the rose to brother', 'Glass blower lessons','321 pages','256','263','0'),('4','From the heart and kidneys, and what kind of lump is this?', 'Surgery of the CIS countries','500 pages','536','23452534','0'),('2','Five minutes flight is nor...', 'A short tutorial on how to fold a parachute','page','12','0','0'),('4','Hooray remote!', 'DHW','765 pages','150','1275','0'), ('1','Im not an archer, but a shooter!', 'Psychology for women','1500 pages','500','10201','0')", db);

            try
            {
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                Thread.Sleep(500);
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();
                command6.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally { db.Close(); }
        }
    }
}