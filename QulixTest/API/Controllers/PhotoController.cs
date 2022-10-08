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

            return photos;
        }

        //TODO: Сделай по REST спецификации
    }
}