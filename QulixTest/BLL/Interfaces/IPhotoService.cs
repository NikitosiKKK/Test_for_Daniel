using System.Collections.Generic;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IPhotoService
    {
        public List<PhotoModel> List();
        public PhotoModel Get(int id);
        public void Update(PhotoModel photoModel, int id);
        public void SetRating(int rating, int id);
    }
}