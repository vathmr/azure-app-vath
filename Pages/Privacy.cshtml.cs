using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_vath.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    private readonly IConfiguration _Configuration;

    public PrivacyModel(ILogger<PrivacyModel> logger, IConfiguration configuration)
    {
        _logger = logger;
        _Configuration = configuration;
    }

    public void OnGet()
    {
        ViewData["Greeting"] = _Configuration["Greeting"];
    }
}

