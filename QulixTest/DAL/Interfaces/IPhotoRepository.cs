using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPhotoRepository
    {
        public List<PhotoEntity> List();
        public PhotoEntity Get(int id);
        public void Update(PhotoEntity entity, int id);
        public void SetRating(int id, int rating);
        public void Delete(int id);
    }
}
