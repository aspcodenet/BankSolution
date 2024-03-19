using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Models;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DateTime Datum { get; set; }
        public List<Player> Players { get; set; } = new ();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Datum = DateTime.Now;
            Players.Add(new Player{Id=1,Jersey =21,Name="Foppa",Team="Modo"});
            Players.Add(new Player { Id = 2, Jersey = 67, Name = "Omark", Team = "Luleå" });
            Players.Add(new Player { Id = 3, Jersey = 13, Name = "Mats Sundin", Team = "DIF" });
//            Players.Add(new Player { Id = 4, Jersey = 0, Name = "Mario Kempe", Team = "Luleå" });

        }

    }
}
