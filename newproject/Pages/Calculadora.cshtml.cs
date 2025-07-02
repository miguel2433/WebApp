using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace newproject.Pages
{
    public class Calculadora : PageModel
    {
        private readonly ILogger<Calculadora> _logger;

        public Calculadora(ILogger<Calculadora> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}