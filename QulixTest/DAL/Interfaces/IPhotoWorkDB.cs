using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPhotoWorkDB
    {
        public List<PhotoModelDB> GetPhotos();
        public PhotoModelDB GetPhotoByName(string name);
        public void ChangePhotoByName(PhotoModelDB photoModel, string name);
        public void GetRating(PhotoModelDB rating, string name);
    }
}
