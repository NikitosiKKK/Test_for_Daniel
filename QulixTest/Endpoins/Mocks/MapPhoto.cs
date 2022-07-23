using Endpoins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace Endpoins.Mocks
{
    public static class MapPhoto
    {

        public static List<PhotoModel> Maps(List<PhotoModelDB> _photo)
        {
            var photos = new List<PhotoModel>();
            foreach (var photo in _photo)
            {
                var photoModel = new PhotoModel();
                photoModel.Date = photo.Date;
                photoModel.Price = photo.Price;
                photoModel.Purchases = photo.Purchases;
                photoModel.Url = photo.Url;
                photoModel.AuthorId = photo.AuthorId;
                photoModel.Rating = photo.Rating;
                photoModel.Name = photo.Name;
                photoModel.Size = photo.Size;
                photos.Add(photoModel);
            }
            return photos;
        }
        public static PhotoModel Map(PhotoModelDB _photo)
        {
            
            
                var photo = new PhotoModel();
                photo.Date = _photo.Date;
                photo.Price = _photo.Price;
                photo.Purchases = _photo.Purchases;
                photo.Url = _photo.Url;
                photo.AuthorId = _photo.AuthorId;
                photo.Rating = _photo.Rating;
                
            
            return photo;
        }
        public static PhotoModelDB Map(PhotoModel _photo) {
            var photo = new PhotoModelDB();
            photo.Date = _photo.Date;
            photo.Price = _photo.Price;
            photo.Purchases = _photo.Purchases;
            photo.Url = _photo.Url;
            photo.AuthorId = _photo.AuthorId;
            photo.Rating = _photo.Rating;


            return photo;

        }
    }
}
