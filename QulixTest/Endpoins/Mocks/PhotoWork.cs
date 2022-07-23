using Dapper;
using Endpoins.Interfaces;
using Endpoins.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using DAL.Interfaces;



namespace Endpoins.Mocks
{
    public class PhotoWork : IPhotoWork
    {
        private  IPhotoWorkDB _photoWork;


        public PhotoWork (IPhotoWorkDB photoWork)
        {
            _photoWork = photoWork;
            
        }

        public List<PhotoModel> GetPhotos()
        {
            
            var photos = MapPhoto.Maps(_photoWork.GetPhotos());
            return photos;

        }
        public PhotoModel GetPhotoByName(string name)
        {

            var photo= MapPhoto.Map(_photoWork.GetPhotoByName(name));
            return photo;

            
        }
        public void ChangePhotoByName(PhotoModel photo, string name)
        {
             _photoWork.ChangePhotoByName(MapPhoto.Map(photo), name);

        }
        public void GetRating(PhotoModel photo, string name)
        {
            _photoWork.GetRating(MapPhoto.Map(photo), name);
        }
    }
    }
