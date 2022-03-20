using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationTest1.Application;

namespace WebApplicationTest1.Pages.InnerLoad
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IInnerLoad innerload;
        public string ConnectionString { get => innerload.GetConnectionString(); }

        public IndexModel(ILogger<IndexModel> logger, IInnerLoad innerload)
        {
            _logger = logger;
            this.innerload = innerload;
        }

        public void OnGet()
        {

        }
    }
}
