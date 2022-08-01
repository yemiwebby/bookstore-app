#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesBookstore.Models;

namespace BookstoreApp.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly AppContext _context;

        public CreateModel(AppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        [BindProperty]
        public int SelectedAuthorId {set; get;}

        public List<SelectListItem> Authors { set; get; }

        public IActionResult OnGet()
        {
            Authors = _context.Author.Select(
                author => new SelectListItem
                {
                    Text = author.Name,
                    Value = author.ID.ToString()
                }).ToList();
            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Book.Author = _context.Author.Find(this.SelectedAuthorId);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}