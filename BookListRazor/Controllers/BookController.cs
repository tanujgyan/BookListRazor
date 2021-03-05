using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDBContext _db;
        public BookController(ApplicationDBContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
           var books=  Json(new {data= _db.Book.ToList() });
            return books;
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var book = await _db.Book.FirstOrDefaultAsync(b => b.Id == id);
            if(book!=null)
            {
                _db.Book.Remove(book);
                await _db.SaveChangesAsync();
                return Json(new { success = true, message = "Deleted Successfully" });
            }
            else
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
        }
    }
}
