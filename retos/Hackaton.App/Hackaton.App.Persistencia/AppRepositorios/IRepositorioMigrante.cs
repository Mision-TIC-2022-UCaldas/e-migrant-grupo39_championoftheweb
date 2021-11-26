using System.Collections.Generic;
using Hackaton.App.Dominio;

namespace Hackaton.App.Persistencia
{
    public interface IRepositorioMigrante
    {
         Migrante AddMigrante(Migrante migrante);
         //Migrante GetMigrante(int identMigrante);
         //Migrante UpdateMigrante(Migrante migrante);
         //bool DeleteMigrante(int identMigrante);
         //IEnumerable<Migrante> GetAllMigrantes();

    }
}