using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(int id)
        {
           Book= await _db.Book.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var entity = _db.Book.FirstOrDefault(x => x.Id == Book.Id);
                if(entity!=null)
                {
                    entity.Name = Book.Name;
                    entity.Author = Book.Author;
                    entity.ISBN = Book.ISBN;
                    await _db.SaveChangesAsync();
                }
                
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
