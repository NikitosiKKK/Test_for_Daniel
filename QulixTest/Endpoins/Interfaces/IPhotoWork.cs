using Endpoins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endpoins.Interfaces
{
    public interface IPhotoWork
    {
        public List<PhotoModel> GetPhotos();
        public PhotoModel GetPhotoByName(string name);
        public void ChangePhotoByName(PhotoModel photoModel, string name);
        public void GetRating(PhotoModel rating, string name);
        //public SearchPhoto GetSearchPhoto();
    }
}
