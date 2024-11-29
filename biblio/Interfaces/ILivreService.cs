using biblio.DTOs;
using biblio.Models;

namespace biblio.Interfaces
{
    public interface ILivreService
    {
        IEnumerable<LivreDTO> ListerLivres();
        void AjouterLivre(LivreDTO livre);
        void ModifierLivre(int id, LivreDTO livre);
    }
}
