using DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace QulixTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : Controller
    {
        ITextRepository repo;
        public TextController(ITextRepository r)
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
            repo.GetAllText();
            return RedirectToAction("Index");
        }
    }
}
