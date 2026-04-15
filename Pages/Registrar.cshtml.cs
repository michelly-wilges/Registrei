using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Registrei.Data;
using Registrei.Models;

namespace Registrei.Pages
{
    public class RegistrarModel : PageModel
    {
        private readonly AppDbContext _context;
        public RegistrarModel(AppDbContext context)
        {
            _context = context;
        }
        
        [BindProperty]
        public Servico Servico { get; set; }

        public string Mensagem { get; set; }
        public void OnPost()
        {
            _context.Servicos.Add(Servico);
            _context.SaveChanges();

            Mensagem = "Serviço salvo com sucesso!";
        }
    }
}