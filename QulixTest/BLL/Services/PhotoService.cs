using BLL.Interfaces;
using BLL.Maps;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public  class PhotoService:IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;
        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository= photoRepository;
        }

        public void ChangePhoto(PhotoModel photoModel, int id)
        {
            _photoRepository.Update(PhotoMap.Map(photoModel), id);
        }

        public PhotoModel GetPhoto(int id)
        {
            return PhotoMap.Map(_photoRepository.Get(id));
        }

        public List<PhotoModel> GetPhotos()
        {
            
            return PhotoMap.Maps(_photoRepository.List()); ;
        }

        public void SetRating(int rating, int id)
        {
            _photoRepository.SetRating( rating, id);
        }
    }
}
