using BLL.Interfaces;
using BLL.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        IPhotoService repo;
        DBWork dataBase = new DBWork();
        public PhotoController(IPhotoService r)
        {
            repo = r;
        }
        [HttpGet]
        public List<PhotoModel> Index()
        {
            return repo.GetPhotos();

        }

        [HttpGet("getphoto={id}")]
        public PhotoModel Details(int id)
        {
            return repo.GetPhoto(id);
        }

        [HttpPost("Update={id}")]
        public void Update([FromForm] PhotoModel photo, int id)
        {

                repo.ChangePhoto(photo, id);
                
        }

        [HttpPost("UpdateRating={id}")]
        public void UpdateRating(int rating, int id)
        {
            repo.SetRating(rating, id);
        }
        [HttpGet("CreateDB")]
        public ActionResult CreateDB()
        {
            dataBase.CreateDB();
            return RedirectToAction("Index");
        }
    }
}
