using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SignalRChat.Models;

namespace SignalRChat.Pages
{
    public class IndexModel : PageModel
    {
        //önceki mesajları çekmek için
        readonly ApplicationDbContext _dbContext;
        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Message> Messages { get; set; }
        //--------------
        // private readonly ILogger<IndexModel> _logger;

        //  public IndexModel(ILogger<IndexModel> logger)
        //  {
        //     _logger = logger;
        //  }

        public void OnGet()
        {
        //-----
        Messages = _dbContext.Messages.ToList();
        }
    }
}
