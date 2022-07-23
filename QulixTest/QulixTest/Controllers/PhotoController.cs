using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Endpoins.Models;
using Endpoins.Interfaces;

namespace QulixTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : Controller
    {
        IPhotoWork repo;
        DBCreation dataBase = new DBCreation();
        public PhotoController(IPhotoWork r)
        {
            repo = r;
        }
        [HttpGet]
        public ActionResult Index()
        {


            return View(repo.GetPhotos());

        }
        [HttpPost]
        public ActionResult Index([FromForm] string name)
        {
            return RedirectToAction("Details", new { name = name });
        }
        [HttpGet("getphotobyname={name}")]
        public ActionResult Details(string name)
        {
            PhotoModel photo = repo.GetPhotoByName(name);
            if (photo != null)
                return View(photo);
            return NotFound();
        }

        [HttpGet("Update={name}")]
        public ActionResult Update(string name)
        {
            PhotoModel photo = repo.GetPhotoByName(name);
            if (photo != null)
                return View(photo);
            return NotFound();
        }
        [HttpPost("Update={name}")]
        public ActionResult Update([FromForm] PhotoModel photo, string name)
        {
            if (string.IsNullOrEmpty(photo.Name) || photo.Purchases == null || photo.Url == null || photo.Price == null || photo.Size == null) { return RedirectToAction("Update"); }
            else
            {
                repo.ChangePhotoByName(photo, name);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("UpdateRating={name}")]
        public ActionResult UpdateRating(string name) {
            PhotoModel photo = repo.GetPhotoByName(name);
            if (photo != null)
                return View(photo);
            return NotFound();
        }

        [HttpPost("UpdateRating={name}")]
        public ActionResult UpdateRating([FromForm] PhotoModel photo, string name) {
            if (photo.Rating > 10 || photo.Rating < 0)
            {
                return RedirectToAction("UpdateRating");
            }
            repo.GetRating(photo, name);
            return RedirectToAction("Index");
        }
        [HttpGet("CreateDB")]
        public ActionResult CreateDB() { 
            dataBase.CreateDB();
        return RedirectToAction("Index");
        }
        }
    }
