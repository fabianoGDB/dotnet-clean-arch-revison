using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CleanStore.Pwa.AccountContext.UseCases.Create
{
    public class CreatePage.razor : PageModel
    {
        private readonly ILogger<CreatePage.razor> _logger;

        public CreatePage.razor(ILogger<CreatePage.razor> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}