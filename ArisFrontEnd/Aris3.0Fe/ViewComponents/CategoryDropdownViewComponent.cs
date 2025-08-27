using Aris3._0FE.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Aris.ViewComponents
{
    public class CategoryDropdownViewComponent:ViewComponent
    {
        private readonly ArisDbContext _context;

        public CategoryDropdownViewComponent(ArisDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
    }
}
