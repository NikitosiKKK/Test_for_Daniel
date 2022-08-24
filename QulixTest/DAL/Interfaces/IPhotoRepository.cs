using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IPhotoRepository
    {
        public List<PhotoEntity> List();
        public PhotoEntity Get(int id);
        public void Update(PhotoEntity entity);
        public void Delete(int id);
    }
}