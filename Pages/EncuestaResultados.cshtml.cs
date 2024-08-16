using EncuestaWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace EncuestaWeb.Pages
{
    public class EncuestaResultadosModel : PageModel
    {
        private readonly EncuestaService _encuestaService;

        public List<Encuesta> Encuestas { get; set; }

        public EncuestaResultadosModel(EncuestaService encuestaService)
        {
            _encuestaService = encuestaService;
        }

        public void OnGet()
        {
            Encuestas = _encuestaService.GetEncuestas().ToList();
        }
    }
}