using Microsoft.AspNetCore.Components;
using Sieve.Models;
using Sieve.Services.POS;

namespace Sieve.BSA.Pages.Products
{
    public partial class Add
    {
        protected PRODUCTS products = new();
        protected override async Task OnParametersSetAsync()
        {

        }
        protected async Task SaveUser()
        {
            new ProductService().AddProducts(products); 
        }
        public void Cancel()
        {
           // NavigationManager.NavigateTo("/Pages/Products/Lists");
        }
    }
}
