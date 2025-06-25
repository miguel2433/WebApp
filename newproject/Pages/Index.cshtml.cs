using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace newproject.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public string nombreUsuario { get; set; }
    public string apellido { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost(string nombreUsuario, string apellido)
    {
        this.nombreUsuario = nombreUsuario;
        this.apellido = apellido;
    }
}
