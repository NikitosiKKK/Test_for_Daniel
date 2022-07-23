using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Endpoins.Interfaces;
using Endpoins.Models;
using System.Collections.Generic;

namespace QulixTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : Controller
    {
        ITextWork repo;
        public TextController(ITextWork r)
        {
            repo = r;
        }
        [HttpGet]
        public ActionResult Index()
        
        {
            return View(repo.GetAllText());
        }
        [HttpPost]
        public ActionResult TextText() {
            repo.TextAll();
            return RedirectToAction("Index");
        }
    }
}
