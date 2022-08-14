using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Models;
using BLL.Interfaces;
using DAL;

namespace QulixTest.Controllers
{
    [Route("[controller]")]
    public class PhotoController : Controller
    {
        IPhotoService repo;
        DBWork dataBase = new DBWork();
        public PhotoController(IPhotoService r)
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
        [HttpGet("getphotobyid={id}")]
        public ActionResult Details(int id)
        {
            PhotoModel photo = repo.GetPhoto(id);
            if (photo != null)
                return View(photo);
            return NotFound();
        }

        [HttpGet("Update={id}")]
        public ActionResult Update(int id)
        {
            PhotoModel photo = repo.GetPhoto(id);
            if (photo != null)
                return View(photo);
            return NotFound();
        }
        [HttpPost("Update={id}")]
        public ActionResult Update([FromForm] PhotoModel photo, int id)
        {
            if (string.IsNullOrEmpty(photo.Name) || photo.Purchases == null || photo.Url == null || photo.Price == null || photo.Size == null) { return RedirectToAction("Update"); }
            else
            {
                repo.ChangePhoto(photo, id);
                return RedirectToAction("Index");
            }
        }

        [HttpGet("UpdateRating={id}")]
        public ActionResult UpdateRating(int id) {
            PhotoModel photo = repo.GetPhoto(id);
            if (photo != null)
                return View(photo);
            return NotFound();
        }

        [HttpPost("UpdateRating={id}")]
        public ActionResult UpdateRating(int rating, int id) {
            if (rating > 10 || rating < 0)
            {
                return RedirectToAction("UpdateRating");
            }
            repo.SetRating(rating, id);
            return RedirectToAction("Index");
        }
        [HttpGet("CreateDB")]
        public ActionResult CreateDB() { 
            dataBase.CreateDB();
        return RedirectToAction("Index");
        }
        }
    }
