using biblio.DTOs;

namespace biblio.Interfaces
{
    public interface ICategorieService
    {
        IEnumerable<CategorieDTO> ListerCategorie();
        void AjouterCategorie(CategorieDTO categorie);
        void ModifierCategorie(int id, CategorieDTO categorie);
    }
}
