using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace gerenciador_de_estoque.Pages
{
    public class Controle : PageModel
    {
        private readonly ILogger<Controle> _logger;

        public Controle(ILogger<Controle> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
