using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Costea_Cosmina_lab8.Data;
using Costea_Cosmina_lab8.Models;

namespace Costea_Cosmina_lab8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Costea_Cosmina_lab8.Data.Costea_Cosmina_lab8Context _context;

        public CreateModel(Costea_Cosmina_lab8.Data.Costea_Cosmina_lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
