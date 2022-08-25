using System.Collections.Generic;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IPhotoService
    {
        public List<PhotoModel> List();
        public PhotoModel Get(int id);
        public PhotoModel Update(PhotoModel photoModel);
        public PhotoModel SetRating(int rating, int id);
    }
}