using Sieve.Models;
using Sieve.Services.POS;

namespace Sieve.BSA.Pages.Products
{
    public partial class Lists
    {
        protected List<PRODUCTS> PRODUCTS = new List<PRODUCTS>();
        protected override async Task OnInitializedAsync()
        {
            PRODUCTS = new ProductService().GetAll();
        }
    }
}
