using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationTest1.Application;

namespace WebApplicationTest1.Pages.DiLoad
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDiLoad _diLoad;
        public string ConnectionString { get => _diLoad.GetConnectionString(); }

        public IndexModel(ILogger<IndexModel> logger, IDiLoad diLoad)
        {
            _logger = logger;
            _diLoad = diLoad;
        }

        public void OnGet()
        {

        }
    }
}
