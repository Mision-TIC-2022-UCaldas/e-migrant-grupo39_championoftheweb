using System.Collections.Generic;
using System.Linq;
using Hackaton.App.Dominio;

namespace Hackaton.App.Persistencia
{
    public class RepositorioMigrantes:IRepositorioMigrante
    {
        private readonly AppContext _appContext;
        public RepositorioMigrantes(AppContext appContext)
        {
            _appContext=appContext;
        }
        Migrante IRepositorioMigrante.AddMigrante(Migrante migrante){
            var migranteAdicionado = _appContext.Migrantes.Add(migrante);
            _appContext.SaveChanges();
            return migranteAdicionado.Entity;
        }

    }
}