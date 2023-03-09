using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission9_owenk7.Models;

namespace Mission9_owenk7.Pages
{
    public class CheckoutModel : PageModel
    {
        private IBookstoreRepository repository { get; set; }

        public CheckoutModel(IBookstoreRepository temp)
        {
            repository = temp;
        }

        public Cart cart { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repository.Books.FirstOrDefault(x => x.BookId == bookId);

            // evaluate left first ??
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            cart.AddItem(b, 1);

            HttpContext.Session.SetJson("cart", cart);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}