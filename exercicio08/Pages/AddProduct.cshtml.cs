using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exercicio08.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public string name { get; set; }
        [BindProperty]
        public decimal price { get; set; }

        public string Message { get; set; }

        public void OnPost()
        {
            Message = $"Cadastrado: {name} por {price:C}";
        }
    }
}
