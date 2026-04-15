using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Registrei.Data;
using Registrei.Models;

namespace Registrei.Pages
{
    public class ListarModel : PageModel
    {
        private readonly AppDbContext _context;
        
        public ListarModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Servico> Servicos { get; set; }

        public void OnGet()
        {
            Servicos = _context.Servicos.ToList();
        }
    }
}