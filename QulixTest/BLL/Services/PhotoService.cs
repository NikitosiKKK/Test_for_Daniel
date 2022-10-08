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

        public PhotoModel Update(int id, PhotoUpdateModel photoModel)
        {
            var photoEntity = PhotoMap.Map(photoModel, id);
            var updatedEntity = _photoRepository.Update(photoEntity);
            return PhotoMap.Map(updatedEntity);
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

        public PhotoModel SetRating(int rating, int id)
        {
            var entity = _photoRepository.Get(id);

            entity.Rating = rating;
            
            var updatedEntity = _photoRepository.Update(entity);
            
            return PhotoMap.Map(updatedEntity);
        }
    }
}