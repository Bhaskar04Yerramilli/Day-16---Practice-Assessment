using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorProductsApp.Models;

namespace RazorProductsApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Product NewProduct { get; set; }

        public static List<Product> Products = new List<Product>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Products.Add(NewProduct);
            return RedirectToPage();
        }
    }
}