using BLL.Models;
using DAL.Entities;

namespace BLL.Maps
{
    public static class PhotoMap
    {
        public static PhotoModel Map(PhotoEntity photo)
        {
            var photoModel = new PhotoModel
            {
                Id = photo.Id,
                Date = photo.Date,
                Price = photo.Price,
                Purchases = photo.Purchases,
                Url = photo.Url,
                AuthorId = photo.AuthorId,
                Rating = photo.Rating,
                Name = photo.Name,
                Size = photo.Size
            };

            return photoModel;
        }

        public static PhotoEntity Map(PhotoModel photo)
        {
            var photoEntity = new PhotoEntity
            {
                Id = photo.Id,
                Date = photo.Date,
                Price = photo.Price,
                Purchases = photo.Purchases,
                Url = photo.Url,
                AuthorId = photo.AuthorId,
                Rating = photo.Rating,
                Name = photo.Name,
                Size = photo.Size
            };

            return photoEntity;
        }
        public static PhotoEntity Map(PhotoUpdateModel photo, int id)
        {
            var photoEntity = new PhotoEntity
            {
                Id = id,
                Date = photo.Date,
                Price = photo.Price,
                Purchases = photo.Purchases,
                Url = photo.Url,
                AuthorId = photo.AuthorId,
                Rating = photo.Rating,
                Name = photo.Name,
                Size = photo.Size
            };

            return photoEntity;
        }
    }
}