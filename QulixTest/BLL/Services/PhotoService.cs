using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces;
using BLL.Maps;
using BLL.Models;
using DAL.Interfaces;

namespace BLL.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;

        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public void Update(PhotoModel photoModel, int id)
        {
            var photoEntity = PhotoMap.Map(photoModel);
            _photoRepository.Update(photoEntity);
        }

        public PhotoModel Get(int id)
        {
            var photoEntity = _photoRepository.Get(id);
            
            return PhotoMap.Map(photoEntity);
        }

        public List<PhotoModel> List()
        {
            var photoEntities = _photoRepository.List();

            var photoModels = photoEntities.Select(p => PhotoMap.Map(p));
            return photoModels.ToList();
        }

        public void SetRating(int rating, int id)
        {
            var entity = _photoRepository.Get(id);

            entity.Rating = rating;
            
            _photoRepository.Update(entity);
        }
    }
}