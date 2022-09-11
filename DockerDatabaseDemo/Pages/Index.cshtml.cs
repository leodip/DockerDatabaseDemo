using DockerDatabaseDemo.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DockerDatabaseDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly StoreContext _context;

        public IndexModel(StoreContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var rnd = new Random();

            _context.Products.Add(new Product()
            {
                Name = "One product",
                Price = rnd.Next(100, 1000)
            });

            _context.Products.Add(new Product()
            {
                Name = "Another product",
                Price = rnd.Next(100, 1000)
            });
            await _context.SaveChangesAsync();

            Products = await _context.Products.ToListAsync();
        }
    }
}