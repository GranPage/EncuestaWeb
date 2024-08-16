using EncuestaWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EncuestaWeb.Pages
{
    public class EncuestaModel : PageModel
    {
        private readonly EncuestaService _encuestaService;

        [BindProperty]
        public Encuesta Encuesta { get; set; }

        public EncuestaModel(EncuestaService encuestaService)
        {
            _encuestaService = encuestaService;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _encuestaService.AddEncuesta(Encuesta);
            return RedirectToPage("/EncuestaResultados");
        }
    }
}