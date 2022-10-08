using System.Collections.Generic;
using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        [HttpGet("")]
        public ActionResult<List<PhotoModel>> List()
        {
            var photos = _photoService.List();

            return Ok(photos);
        }
        [HttpGet("id")]
        public ActionResult<PhotoModel> PhotoModel(int id)
        {
            var photo = _photoService.Get(id);

            return Ok(photo);
        }
        [HttpPost("id")]
        public ActionResult<PhotoModel> Update(int id, PhotoUpdateModel photoModel)
        {
            var photo = _photoService.Update(id, photoModel);

            return photo;
        }
        [HttpPost("setrating/id")]
        public ActionResult<PhotoModel> SeteRating(int rating, int id)
        {
            var photo = _photoService.SetRating(rating, id);

            return photo;
        }
        //TODO: Сделай по REST спецификации
    }
}