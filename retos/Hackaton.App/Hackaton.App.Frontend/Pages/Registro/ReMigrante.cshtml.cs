using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Dominio;
using Hackaton.App.Persistencia;

namespace Hackaton.App.Frontend.Pages
{
    public class ReMigranteModel : PageModel
    {
        private static IRepositorioMigrante _repoMigrate =new RepositorioMigrantes(new Persistencia.AppContext());
        [BindProperty]
        public Migrante Migrante{get;set;}
        public IActionResult OnGet()
        {
            Migrante = new Migrante();
            return Page();
        }
        public IActionResult OnPost()
        {
            Migrante = _repoMigrate.AddMigrante(Migrante);
            Console.WriteLine("se creó el imigrnate: "+Migrante.nombre+Migrante.identificacion);
            return Page();
        }
    }
}
