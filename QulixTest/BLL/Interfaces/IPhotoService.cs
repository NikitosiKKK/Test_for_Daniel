using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPhotoService
    {
        public List<PhotoModel> GetPhotos();
        public PhotoModel GetPhoto(int id);
        public void ChangePhoto(PhotoModel photoModel, int id);
        public void SetRating(int rating, int id);
        
    }
}
