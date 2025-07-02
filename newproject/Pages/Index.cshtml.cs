using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace newproject.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string nombreUsuario { get; set; }
    public string contra { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost(string nombreUsuario, string contra)
    {
        this.nombreUsuario = nombreUsuario;
        this.contra = contra;
        return RedirectToPage("/Home");
    }
}
